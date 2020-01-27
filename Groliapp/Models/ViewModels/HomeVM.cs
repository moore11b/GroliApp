///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 3
//	File Name:		HomeVM.cs
//	Course:			CSCI 3110-001 -Advanced Web
//	Author:			Cory Moore, moorecs1@etsu.edu, Department of Computing, East Tennessee State University
//	Created:		Thursday November 10th 2019
//	Copyright:		Cory Moore, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using Groliapp.Models.Entities;
using System.Collections.Generic;

namespace Groliapp.Models.ViewModels
{
    /// <summary>
    /// Used for the Home Index page. 
    /// </summary>
    public class HomeVM
    {
        public int GroceryListCount { get; set; }
        public string GroceryListName { get; set; }
        public int ItemCount { get; set; }//Number of grocery items in a specific list. 
        public IEnumerable<GroceryList> GroceryLists { get; set; }
        public IEnumerable<GroceryItem> GroceryItems { get; set; }
        public string UserEmail { get; set; }//Email address of the user that is currently logged in. 
        public string OwnerEmail { get; set; }//Email address of the user that owns a specfic grocery list. 
    }//end class
}//end namespace