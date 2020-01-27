///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 3
//	File Name:		UserListVM.cs
//	Course:			CSCI 3110-001 -Advanced Web
//	Author:			Cory Moore, moorecs1@etsu.edu, Department of Computing, East Tennessee State University
//	Created:		Thursday November 10th 2019
//	Copyright:		Cory Moore, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using Groliapp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Groliapp.Models.ViewModels
{
    /// <summary>
    /// View model for various crud operations for User information. 
    /// </summary>
    public class UserListVM
    {
        public string OwnerId { get; set; } //Unique ID for the user that owns a list. 
                                            //May not necessarily be the user that is currently logged in. 
        public string UserId { get; set; }//the Unique ID for the user that is currently logged in. 
        public int ListId { get; set; }
        public string ListName { get; set; }
        public IQueryable<ApplicationUser> UserList { get; set; }
        public ICollection<string> PriviledgedUsers { get; set; }
        public ICollection<string> NonPriviledgedUsers { get; set; }
    }//end class
}//end namespace
