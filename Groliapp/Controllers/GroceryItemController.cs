///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 3
//	File Name:		GroceryItemController.cs
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
using Microsoft.AspNetCore.Mvc;
using Groliapp.Models.ViewModels;
using Groliapp.Services.Interfaces;
using Groliapp.Models.Entities;
using Microsoft.AspNetCore.Identity;
namespace Groliapp.Controllers
{
    /// <summary>
    /// This is the class that controls operations in regards to Grocery Items. 
    /// Injects the dependency for grocery list and item repositories.
    /// Implements the Controller class. 
    /// </summary>
    public class GroceryItemController : Controller
    {
        #region Dependency Injection
        IGroceryListRepository _groceryLists;
        IGroceryItemRepository _groceryItem;
        /// <summary>
        /// Constructor for the Grocery Item Controller. 
        /// Injects the dependency for grocery list and item repositories.
        /// Implements the Controller class. 
        /// </summary>
        /// <param name="groceryLists"></param>
        /// <param name="groceryItem"></param>
        public GroceryItemController(IGroceryListRepository groceryLists, IGroceryItemRepository groceryItem)
        {
            _groceryLists = groceryLists;
            _groceryItem = groceryItem;
        }
        #endregion


        /// <summary>
        /// Used internally to see if a request is an Ajax request
        /// </summary>
        /// <returns></returns>
        private bool IsAjaxRequest()
        {
            return Request.Headers["X-Requested-With"] == "XMLHttpRequest";
        }

        #region Create Action Method
        /// <summary>
        /// POST requested method used to create grocery item instances. 
        /// </summary>
        /// <param name="groceryItem"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create(GroceryItem groceryItem)
        {
            groceryItem.OwnerEmail = this.User.Identity.Name;
            
            var newGroceryItem =  _groceryItem.CreateGroceryItem(groceryItem);
            newGroceryItem.OwnerEmail = this.User.Identity.Name;
            return Json(new { newGroceryItem.Id });
        }
        /// <summary>
        /// The GET requested method used to create grocery item instances. 
        /// </summary>
        /// <param name="listId"></param>
        /// <returns></returns>
        public IActionResult Create(int listId)
        {
            CreateGroceryVM cgVM = new CreateGroceryVM
            {
                ListId = listId
            };
            return PartialView("_Create" , cgVM);
        }
        #endregion
        #region Delete Action Method
        /// <summary>
        /// The POST requested method used to delete grocery item instances. 
        /// </summary>
        /// <param name="listId"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Delete(int id)
        {
             _groceryItem.DeleteGroceryItem(id);
            return Json(new { id });
        }
        /// <summary>
        /// The POST requested method used to check if grocery items may be 
        /// in a user's physical grocery cart.  Uses Ajax for POST request processing internally.  
        /// </summary>
        /// <param name="listId"></param>
        /// <returns></returns>
        #endregion
        [HttpPost]
        public IActionResult CheckItem(int id)
        {
            _groceryItem.CheckItem(id);
            return Json(new { id });
        }
    }//end class
}//end method. 