///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 3
//	File Name:		CreateGroceryVM.cs
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
    /// This allows the secure creation of a grocery item to be
    /// added to a list. 
    /// </summary>
    public class CreateGroceryVM
    {
        public int ListId { get; set; }
        [DisplayName("Grocery Name")]
        public string ItemName { get; set; }
        [DisplayName("Cost of Grocery")]
        public decimal Amount { get; set; }
        public IEnumerable<GroceryList> GroceryList { get; set; }

    }//end class
}//end namespace
