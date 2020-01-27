///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 3
//	File Name:		CreateGroceryListVM.cs
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
    /// This class is used to securely create
    /// a new instance of a grocery list entity. 
    /// </summary>
    public class CreateGroceryListVM
    {
        public int Id { get; set; }
        [DisplayName("Grocery List Name")]
        public string GroceryListName { get; set; }
        public string OwnerId { get; set; }
        public string OwnerName { get; set; }
        public  ICollection<GroceryItem> GroceryItems { get; set; }
        public ICollection<AssociativeEntity> AssociativeEntities { get; set; }
        /// <summary>
        /// This method is called after Model State validation to create a new grocery list. 
        /// </summary>
        /// <param name="ownerId"></param>
        /// <param name="ownerEmail"></param>
        /// <returns></returns>
        public GroceryList CreateGroceryList(string ownerId, string ownerEmail)
        {
            return new GroceryList
            {
                OwnerId = ownerId, 
                GroceryListName = GroceryListName ,
                OwnerName = ownerEmail
            };
        }
    }//end class
}//end namespace
