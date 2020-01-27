///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 3
//	File Name:		DGroceryListRepository.cs
//	Course:			CSCI 3110-001 -Advanced Web
//	Author:			Cory Moore, moorecs1@etsu.edu, Department of Computing, East Tennessee State University
//	Created:		Thursday November 10th 2019
//	Copyright:		Cory Moore, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using Groliapp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Groliapp.Data;
using Groliapp.Models.Entities;

namespace Groliapp.Services
{
    /// <summary>
    /// This represents an instance of the repository for
    /// grocery lists. 
    /// </summary>
    public class DbGroceryListRepository : IGroceryListRepository
    {
        /// <summary>
        /// Private field DbContext injection. 
        /// </summary>
        ApplicationDbContext _db;
        /// <summary>
        /// Constructor for the Grocery List repository. Injects the DbContext. 
        /// </summary>
        /// <param name="db"></param>
        public DbGroceryListRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        /// <summary>
        /// This method allows the owner of a GroceryList to 
        /// allow access to other users. 
        /// </summary>
        /// <param name="listId"></param>
        /// <param name="userId"></param>
        public void GrantPermission(int listId, string userId)
        {
            var list = ReadGroceryList(listId);
            var user = _db.Users.FirstOrDefault(u => u.Id == userId);
            var relationship = new AssociativeEntity
            {
                GroceryListId = list.Id,
                PrivUserEmail = user.Email,
                PrivUserId = user.Id
            };
            list.AssociativeEntities.Add(relationship);
            _db.SaveChanges();
        }
        /// <summary>
        /// This method allows the owner of a GroceryList to 
        /// revoke access to other users. 
        /// </summary>
        /// <param name="listId"></param>
        /// <param name="userId"></param>
        public void RevokePermission(int listId, string userId)
        {
            var list = ReadGroceryList(listId);
            var user = _db.Users.FirstOrDefault(u => u.Id == userId);
            list.AssociativeEntities.Remove(list.AssociativeEntities.Where(a => a.PrivUserId == userId).FirstOrDefault());
            _db.SaveChanges();
        }
        #region Cruds Ops
        /// <summary>
        /// This method creates a new grocery list instance.
        /// </summary>
        /// <param name="gl"></param>
        /// <returns></returns>
        public GroceryList CreateGroceryList(GroceryList gl)
        {
            _db.GroceryLists.Add(gl);
            _db.SaveChanges();
            return gl;
        }
        /// <summary>
        /// Reads all the Grocery lists owned by a specific user. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>An enumerable list of Groceries</returns>
        public IEnumerable<GroceryList> ReadUserGroceryLists(string id)
        {
            var user = _db.Users.FirstOrDefault(u => u.Id == id);
            List<GroceryList> privList = new List<GroceryList>();
            foreach (var item in ReadAllGroceryLists())
            {
                try
                {
                    if (item.AssociativeEntities.Select(u => u.PrivUserId).Contains(user.Id))
                    {
                        privList.Add(item);
                    }
                }
                catch (Exception)
                {
                    //Only action is to continue the program during if there are no associative entities. 
                }
            }
            return privList;
        }
        /// <summary>
        /// Reads all the grocery lists in the database. 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<GroceryList> ReadAllGroceryLists()
        {
            return _db.GroceryLists
                .Include(a => a.AssociativeEntities)
                .Include(gi => gi.GroceryItems)
                .ToList();
        }
        /// <summary>
        /// This method reads a specific grocery list using the
        /// grocery list's id. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public GroceryList ReadGroceryList(int id)
        {
            return _db.GroceryLists
                .Include(a => a.AssociativeEntities)
                .Include(i => i.GroceryItems)
                .FirstOrDefault(gl => gl.Id == id);
        }
        /// <summary>
        /// This updates the grocery list to a new state.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="gl"></param>
        public void UpdateGroceryList(int id, GroceryList gl)
        {
            var oldList = ReadGroceryList(id);
            if (oldList != null)
            {
                oldList.GroceryItems = gl.GroceryItems;
                oldList.GroceryListName = gl.GroceryListName;
                oldList.OwnerId = gl.OwnerId;
                _db.SaveChanges();
            }
        }
        /// <summary>
        /// This method allows the owner of the list to delete a grocery list
        /// from his/her inventory. 
        /// </summary>
        /// <param name="id"></param>
        public void DeleteGroceryList(int id)
        {
            var groceryList = _db.GroceryLists.Find(id);
            foreach (var item in _db.AssociativeEntities)
            {
                if (item.GroceryListId == id)
                {
                    _db.AssociativeEntities.Remove(item);
                }
            }
            _db.GroceryLists.Remove(groceryList);
            _db.SaveChanges();
        }
        #endregion
    }//end class
}//end namespace
