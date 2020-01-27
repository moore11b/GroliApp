///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 3
//	File Name:		GroceryListController.cs
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
using Groliapp.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Groliapp.Models;
using Groliapp.Models.ViewModels;
using Groliapp.Models.Entities;
using Microsoft.AspNetCore.Authorization;

namespace Groliapp.Controllers
{
    /// <summary>
    /// This class controls operations related to view grocery list pages. 
    /// </summary>
    [Authorize]
    public class GroceryListController : Controller
    {
        #region Dependency Injection
        IGroceryListRepository _groceryLists;
        IUserRepository _userManager;
        IGroceryItemRepository _groceryItem;
        UserManager<ApplicationUser> _manager;
        SignInManager<ApplicationUser> _siManager;
        public GroceryListController(IGroceryListRepository groceryLists,
            IUserRepository userManager, UserManager<ApplicationUser> manager,
            SignInManager<ApplicationUser> siManager,
             IGroceryItemRepository groceryItem)
        {
            _groceryLists = groceryLists;
            _userManager = userManager;
            _manager = manager;
            _siManager = siManager;
            _groceryItem = groceryItem;
        }
        #endregion

        //Check to see IF Ajax
        private bool IsAjaxRequest()
        {
            return Request.Headers["X-Requested-With"] == "XMLHttpRequest";
        }
        /// <summary>
        /// This method calls the partial view that displays 
        /// grocery items in a specific list. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult GroceryItemRow(int id)
        {
            var item = _groceryItem.ReadGroceryItem(id);
            return PartialView("_GroceryItemRow", item);
        }

        #region Create Action Methods
        /// <summary>
        /// GET create method for grocery list instances. 
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            return View();
        }
        /// <summary>
        /// The POST requested method to create Grocery Lists securely
        /// using a View Model. 
        /// </summary>
        /// <param name="cgvm"></param>
        /// <returns></returns>
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Create(CreateGroceryListVM cgvm)
        {
            if (ModelState.IsValid)
            {
                var user = _userManager.ReadAsync(_manager.GetUserId(HttpContext.User));
                GroceryList gL = cgvm.CreateGroceryList(user.Result.Id, user.Result.Email);
                //create a new GroceryList passing the creators id into it
                _groceryLists.CreateGroceryList(gL);
                _groceryLists.GrantPermission(gL.Id, _manager.GetUserId(HttpContext.User));
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        #endregion
        /// <summary>
        /// Calls the delete page using a GET request. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Delete(int id)
        {
            var gList = _groceryLists.ReadGroceryList(id);
            if (gList == null)
            {
                return NotFound("Could not find Grocery List.");
            }
            string userId = _manager.GetUserId(HttpContext.User);
            var projectVM = new DeleteGroceryListVM
            {
                OwnerId = gList.OwnerId,
                GroceryItems = gList.GroceryItems,
                Id = id,
                OwnerName = gList.OwnerName,
                AssociativeEntities = gList.AssociativeEntities,
                GroceryListName = gList.GroceryListName,
                UserId = userId
            };
            return View(projectVM);
        }

       /// <summary>
       /// Deletes a specified grocery list. 
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _groceryLists.DeleteGroceryList(id);
            return RedirectToAction("Index", "Home");
        }

        #region Edit Action Methods

        /// <summary>
        /// POST requested method that controls update operations
        /// for a grocery list. 
        /// </summary>
        /// <param name="groceryList"></param>
        /// <returns></returns>
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Edit(GroceryList groceryList)
        {
            if (ModelState.IsValid)
            {
                _groceryLists.UpdateGroceryList(groceryList.Id, groceryList);
                return RedirectToAction("Index", "Home");
            }
            return View(groceryList);
        }
        #endregion
        /// <summary>
        /// GET Requested method for update operations for a 
        /// specific grocery list. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Edit(int id)
        {
            var groceryList = _groceryLists.ReadGroceryList(id);
            var privUsers = groceryList.AssociativeEntities.Select(u => u.PrivUserEmail).ToList();
            //again get user id
            string userId = _manager.GetUserId(HttpContext.User);
            //get user
            var gList = _groceryItem.ReadAllGroceryItems();
            //Validate
            if (groceryList == null)
            {
                return RedirectToAction("Index", "Home");
            }
            GroceryListVM glVM = new GroceryListVM
            {
                OwnerId = groceryList.OwnerId,
                GroceryItems = gList,
                ListId = id,
                OwnerName = groceryList.OwnerName,
                AssociativeEntities = groceryList.AssociativeEntities,
                GroceryListName = groceryList.GroceryListName,
                UserId = userId,
                UserName = User.Identity.Name,
                PriviledgedUsers = privUsers,
            };
            return View(glVM);
        }
        /// <summary>
        /// Calls the appropriate page that displays information about
        /// a specified grocery list. 
        /// </summary>
        /// <param name="listId"></param>
        /// <returns></returns>
        public IActionResult Details(int listId)
        {
            var groceryList = _groceryLists.ReadGroceryList(listId);
            var gList = _groceryItem.ReadAllGroceryItems();
            var privUsers = groceryList.AssociativeEntities.Select(u => u.PrivUserEmail).ToList();
            string userId = _manager.GetUserId(HttpContext.User);
            GroceryListVM glVM = new GroceryListVM
            {
                GroceryItems = gList,
                PriviledgedUsers = privUsers,
                ListId = listId,
                UserId = userId
            };
            return View(glVM);
        }
        #region View Permissions and make changes to permissions if already allowed
        /// <summary>
        /// Allows an Owner of a grocery list to add or revoke access to 
        /// registered users.  If user is not the owner, they may only be able to see
        /// other users who are granted access.
        /// </summary>
        /// <param name="listId"></param>
        /// <returns></returns>
        public IActionResult Permissions(int listId)
        {
            var groceryList = _groceryLists.ReadGroceryList(listId);
            var userList = _userManager.ReadAllAsync();
            var privUsers = groceryList.AssociativeEntities.Select(u => u.PrivUserEmail).ToList();
            string userId = _manager.GetUserId(HttpContext.User);
            UserListVM model = new UserListVM
            {
                UserList = userList.Result.AsQueryable(),
                PriviledgedUsers = privUsers,
                ListName = groceryList.GroceryListName,
                ListId = listId,
                OwnerId = groceryList.OwnerId ,
                UserId = userId
            };
            return View(model);
        }
        /// <summary>
        /// This method allows the user to grant access to other 
        /// registered users. 
        /// </summary>
        /// <param name="listId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult GrantPermission(int listId, string userId)
        {
            _groceryLists.GrantPermission(listId, userId);
            var groceryList = _groceryLists.ReadGroceryList(listId);
            var userList = _userManager.ReadAllAsync();
            var privUsers = groceryList.AssociativeEntities.Select(u => u.PrivUserEmail).ToList();
            UserListVM model = new UserListVM
            {
                UserList = userList.Result.AsQueryable(),//may need to select non-priv users
                PriviledgedUsers = privUsers,
                ListName = groceryList.GroceryListName,
                ListId = listId,
                OwnerId = groceryList.OwnerId
            };
            return View(model);
        }
        /// <summary>
        /// This method allows the user to revoke access to other 
        /// registered users. 
        /// </summary>
        /// <param name="listId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult RevokePermission(int listId, string userId)
        {
            _groceryLists.RevokePermission(listId, userId);
            var groceryList = _groceryLists.ReadGroceryList(listId);
            var userList = _userManager.ReadAllAsync();
            var privUsers = groceryList.AssociativeEntities.Select(u => u.PrivUserEmail).ToList();
            UserListVM model = new UserListVM
            {
                UserList = userList.Result.AsQueryable(),//may need to select non-priv users
                PriviledgedUsers = privUsers,
                ListName = groceryList.GroceryListName,
                ListId = listId,
                OwnerId = groceryList.OwnerId
            };
            return View(model);
        }

        #endregion
    }//end class
}//end namespace