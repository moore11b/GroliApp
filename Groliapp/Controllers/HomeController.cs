///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 3
//	File Name:		HomeController.cs
//	Course:			CSCI 3110-001 -Advanced Web
//	Author:			Cory Moore, moorecs1@etsu.edu, Department of Computing, East Tennessee State University
//	Created:		Thursday November 10th 2019
//	Copyright:		Cory Moore, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Groliapp.Models;
using Groliapp.Models.ViewModels;
using Groliapp.Services.Interfaces;
using Groliapp.Models.Entities;

namespace Groliapp.Controllers
{
    /// <summary>
    /// This class is the controller for home pages. 
    /// </summary>
    public class HomeController : Controller
    {
        IGroceryListRepository _groceryLists;
        IUserRepository _userRepo;
        IGroceryItemRepository _itemRepo;
        /// <summary>
        /// Constructor for the HomeController class. 
        /// Injects the relevant repositories into the instance. 
        /// </summary>
        /// <param name="groceryLists"></param>
        /// <param name="userRepo"></param>
        /// <param name="itemRepo"></param>
        public HomeController(IGroceryListRepository groceryLists,
           IUserRepository userRepo,
           IGroceryItemRepository itemRepo)
        {
            _groceryLists = groceryLists;
            _userRepo = userRepo;
            _itemRepo = itemRepo;
        }
        /// <summary>
        /// Allows access to the Home Index page. 
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            int listCount;
            if (this.User.Identity.IsAuthenticated)//Only allows access to registered users of the application. 
            {
                var email = this.User.Identity.Name;
                var userId = _userRepo.ReadAsyncByEmail(email).Result.Id;
                try
                {
                    listCount = _groceryLists.ReadUserGroceryLists(userId).Count();
                }
                catch (Exception)
                {
                    listCount = 0;
                }
                var listOfItems = _itemRepo.ReadAllGroceryItems();
                var listsOfGroceryLists = _groceryLists.ReadUserGroceryLists(userId);
                var homeVM = new HomeVM
                {
                    GroceryListCount = listCount,
                    GroceryLists = listsOfGroceryLists,
                    UserEmail = email,
                    GroceryItems = listOfItems
                };
                return View(homeVM);
            }
            else
            {
                var homeVM = new HomeVM
                {
                    GroceryListCount = 0
                };
                return View(homeVM);
            }
        }//end Index

        public IActionResult Privacy()
        {
            return View();
        }


    }//end class
}//end namespace
