///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 3
//	File Name:		GroceryList.cs
//	Course:			CSCI 3110-001 -Advanced Web
//	Author:			Cory Moore, moorecs1@etsu.edu, Department of Computing, East Tennessee State University
//	Created:		Thursday November 10th 2019
//	Copyright:		Cory Moore, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using Groliapp.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Groliapp.Models.Entities
{
    /// <summary>
    /// This class represents an instance of a grocery list entity. 
    /// </summary>
    public class GroceryList
    {
        public int Id { get; set; }
        [Required]
        public string GroceryListName { get; set; }
        public string OwnerId { get; set; }
        public string OwnerName { get; set; }
        public ICollection<GroceryItem> GroceryItems { get; set; }
        /// <summary>
        /// Collection of the relationships between various users and grocery lists. 
        /// </summary>
        public ICollection<AssociativeEntity> AssociativeEntities { get; set; }
    }//end class
}//end namespace
