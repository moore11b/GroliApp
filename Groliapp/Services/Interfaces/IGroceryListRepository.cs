///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 3
//	File Name:		IGroceryListRepository.cs
//	Course:			CSCI 3110-001 -Advanced Web
//	Author:			Cory Moore, moorecs1@etsu.edu, Department of Computing, East Tennessee State University
//	Created:		Thursday November 10th 2019
//	Copyright:		Cory Moore, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using Groliapp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Groliapp.Services.Interfaces
{
    /// <summary>
    /// This represents the interface for the repository of
    /// grocery lists. 
    /// </summary>
    public interface IGroceryListRepository
    {
        /// <summary>
        /// This method creates a new grocery list instance.
        /// </summary>
        /// <param name="gl"></param>
        /// <returns></returns>
        GroceryList CreateGroceryList(GroceryList gi);
        /// <summary>
        /// This method reads a specific grocery list using the
        /// grocery list's id. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        GroceryList ReadGroceryList(int id);
        /// <summary>
        /// Reads all the grocery lists in the database. 
        /// </summary>
        /// <returns></returns>
        IEnumerable<GroceryList> ReadAllGroceryLists();
        /// <summary>
        /// This updates the grocery list to a new state.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="gl"></param>
        void UpdateGroceryList(int id, GroceryList gl);
        /// <summary>
        /// This method allows the owner of the list to delete a grocery list
        /// from his/her inventory. 
        /// </summary>
        /// <param name="id"></param>
        void DeleteGroceryList(int id);
        /// <summary>
        /// Reads all the Grocery lists owned by a specific user. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>An enumerable list of Groceries</returns>
        IEnumerable<GroceryList> ReadUserGroceryLists(string id);
        /// <summary>
        /// This method allows the owner of a GroceryList to 
        /// allow access to other users. 
        /// </summary>
        /// <param name="listId"></param>
        /// <param name="userId"></param>
        void GrantPermission(int listId, string userId);
        /// <summary>
        /// This method allows the owner of a GroceryList to 
        /// revoke access to other users. 
        /// </summary>
        /// <param name="listId"></param>
        /// <param name="userId"></param>
        void RevokePermission(int listId, string userId);
    }
}
