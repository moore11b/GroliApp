///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 3
//	File Name:		GroceryItem.cs
//	Course:			CSCI 3110-001 -Advanced Web
//	Author:			Cory Moore, moorecs1@etsu.edu, Department of Computing, East Tennessee State University
//	Created:		Thursday November 10th 2019
//	Copyright:		Cory Moore, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
namespace Groliapp.Models.Entities
{
    /// <summary>
    /// This class represents the instance of a grocery item entity. 
    /// </summary>
    public class GroceryItem
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        [Required]
        public string ItemName { get; set; }
        public string OwnerEmail { get; set; }
        public int ListId { get; set; }
        public bool IsChecked { get; set; }//Allows the user to keep track of items that may be in a physical grocery cart as an example. 
    
    }//end class
}//end namespace
