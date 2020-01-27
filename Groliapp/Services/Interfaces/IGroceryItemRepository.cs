///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 3
//	File Name:		IGroceryItemRepository.cs
//	Course:			CSCI 3110-001 -Advanced Web
//	Author:			Cory Moore, moorecs1@etsu.edu, Department of Computing, East Tennessee State University
//	Created:		Thursday November 10th 2019
//	Copyright:		Cory Moore, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Groliapp.Models.Entities;

namespace Groliapp.Services.Interfaces
{
    /// <summary>
    /// This represents the interface for the repository for Grocery Items
    /// Complete with Crud operations and DbContext Injection
    /// </summary>
    public interface IGroceryItemRepository
    {
        /// <summary>
        /// This allows any privileged user to add an item to a list
        /// which they have access to. 
        /// </summary>
        /// <param name="groceryItem"></param>
        /// <returns></returns>
        GroceryItem CreateGroceryItem(GroceryItem gi);
        /// <summary>
        /// This method reads a specific item from a grocery list. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        GroceryItem ReadGroceryItem(int id);
        /// <summary>
        /// This method reads all the grocery items from the database. 
        /// </summary>
        /// <returns></returns>
        IEnumerable<GroceryItem> ReadAllGroceryItems();
        /// <summary>
        /// This updates a grocery item instance. 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="gi"></param>
        void UpdateGroceryItem(int id, GroceryItem gi);
        /// <summary>
        /// This method deletes a specified grocery item
        /// from a grocery list using it's ID. 
        /// </summary>
        /// <param name="id"></param>
        void DeleteGroceryItem(int id);
        /// <summary>
        /// This allows privileged users to check off items in their 
        /// grocery list.  The users may choose to use this option
        /// while they're placing items in their physical grocery cart
        /// while at the store. 
        /// </summary>
        /// <param name="id"></param>
        void CheckItem(int id);
    }
}
