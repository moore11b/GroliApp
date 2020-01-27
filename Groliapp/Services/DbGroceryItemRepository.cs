///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 3
//	File Name:		DGroceryItemRepository.cs
//	Course:			CSCI 3110-001 -Advanced Web
//	Author:			Cory Moore, moorecs1@etsu.edu, Department of Computing, East Tennessee State University
//	Created:		Thursday November 10th 2019
//	Copyright:		Cory Moore, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using Microsoft.EntityFrameworkCore;
using Groliapp.Models.Entities;
using Groliapp.Services.Interfaces;
using Groliapp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace Groliapp.Services
{
    /// <summary>
    /// This represents the repository for Grocery Items
    /// Complete with Crud operations and DbContext Injection
    /// </summary>
    public class DbGroceryItemRepository : IGroceryItemRepository
    {

        #region Dependency Injection 
        /// <summary>
        /// Private field DbContext injection. 
        /// </summary>
        ApplicationDbContext _db;
        /// <summary>
        /// Constructor for Grocery Item instances. 
        /// Injects DbContext into each instance. 
        /// </summary>
        /// <param name="db"></param>
        public DbGroceryItemRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        #endregion

        #region Cruds Ops
        /// <summary>
        /// This allows any privileged user to add an item to a list
        /// which they have access to. 
        /// </summary>
        /// <param name="groceryItem"></param>
        /// <returns></returns>
        public GroceryItem CreateGroceryItem(GroceryItem groceryItem)
        {
            _db.GroceryItems.Add(groceryItem);
            _db.SaveChanges();
            return groceryItem;
        }
        /// <summary>
        /// This allows privileged users to check off items in their 
        /// grocery list.  The users may choose to use this option
        /// while they're placing items in their physical grocery cart
        /// while at the store. 
        /// </summary>
        /// <param name="id"></param>
        public void CheckItem(int id)
        {
            var item = _db.GroceryItems.FirstOrDefault(p => p.Id == id);
            if (item != null && item.IsChecked == true)
            {
                item.IsChecked = false;
                _db.SaveChanges();
            }
           else if (item != null && item.IsChecked == false)
            {
                item.IsChecked = true;
                _db.SaveChanges();
            }
        }
        /// <summary>
        /// This method reads all the grocery items from the database. 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<GroceryItem> ReadAllGroceryItems()
        {
            return _db.GroceryItems.ToList();
        }
        /// <summary>
        /// This method reads a specific item from a grocery list. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public GroceryItem ReadGroceryItem(int id)
        {
            return _db.GroceryItems.FirstOrDefault(gi => gi.Id == id);
        }
        /// <summary>
        /// This updates a grocery item instance. 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="gi"></param>
        public void UpdateGroceryItem(int id, GroceryItem gi)
        {
            _db.Entry(gi).State = EntityState.Modified;
            _db.SaveChanges();
        }
        /// <summary>
        /// This method deletes a specified grocery item
        /// from a grocery list using it's ID. 
        /// </summary>
        /// <param name="id"></param>
        public void DeleteGroceryItem(int id)
        {
            var groceryItem = _db.GroceryItems.Find(id);
            _db.GroceryItems.Remove(groceryItem);
            _db.SaveChanges();
        } 
        #endregion

    }//end class
}//end method
