///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 3
//	File Name:		DeleteGroceryListVM.cs
//	Course:			CSCI 3110-001 -Advanced Web
//	Author:			Cory Moore, moorecs1@etsu.edu, Department of Computing, East Tennessee State University
//	Created:		Thursday November 10th 2019
//	Copyright:		Cory Moore, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using Groliapp.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Groliapp.Models.ViewModels
{
    /// <summary>
    /// This is a view model that allows the secure deletion
    /// of a grocery list.  May only be deleted by the owner of the list. 
    /// </summary>
    public class DeleteGroceryListVM
    {
        public int Id { get; set; }
        [DisplayName("Grocery List Name")]
        public string GroceryListName { get; set; }
        public string OwnerId { get; set; }
        public string OwnerName { get; set; }
        public string UserId { get; set; }
        public ICollection<GroceryItem> GroceryItems { get; set; }
        public ICollection<AssociativeEntity> AssociativeEntities { get; set; }//Collection of the relationship between users and grocery lists. 
    }//end class
}//end namespace
