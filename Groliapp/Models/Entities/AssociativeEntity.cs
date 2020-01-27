///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 3
//	File Name:		AssociativeEntity.cs
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

namespace Groliapp.Models.Entities
{
    /// <summary>
    /// Represents the relationship between a user and a grocery list. 
    /// This is created if a user creates or is granted access to a grocery list.  This also
    /// may be deleted if the owner chooses to revoke access. 
    /// </summary>
    public class AssociativeEntity
    {
       public int Id { get; set; }
        public string PrivUserId { get; set; }
        public string PrivUserEmail { get; set; }
        //public GroceryList GroceryList { get; set; }
        public int GroceryListId { get; set; }
    }//end class
}//end namespace
