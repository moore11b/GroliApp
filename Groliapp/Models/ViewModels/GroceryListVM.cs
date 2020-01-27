///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 3
//	File Name:		GroceryListVM.cs
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
    /// View Model for CRUD operations of Grocery Lists. 
    /// </summary>
    public class GroceryListVM
    {
        public int ListId { get; set; }// ID for specified grocery list.
        [DisplayName("Grocery List Name")]
        public string GroceryListName { get; set; }
        public string OwnerId { get; set; }
        public string OwnerName { get; set; }
        public string UserId { get; set; }
        public string UserName{ get; set; }
        public virtual IEnumerable<GroceryItem> GroceryItems { get; set; }
        /// <summary>
        /// Represents a collection of relationships between users and 
        /// grocery lists. 
        /// </summary>
        public virtual ICollection<AssociativeEntity> AssociativeEntities { get; set; }

        public ICollection<string> PriviledgedUsers { get; set; }//Collection of users that have access to the list. 
        public ICollection<string> NonPriviledgedUsers { get; set; }//Collection of users that do not have access to the list. 

    }//end class
}//end namespace
