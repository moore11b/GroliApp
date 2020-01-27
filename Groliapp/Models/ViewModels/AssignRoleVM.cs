///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 3
//	File Name:		AssignRoleVM.cs
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

namespace Groliapp.Models.ViewModels
{
    /// <summary>
    /// This class allows a role to be assigned to a user. 
    /// </summary>
    public class AssignRoleVM
    {
        public string UserName{ get; set; }
        public string RoleName{ get; set; }
        public ICollection<string> UserNames { get; set; }
        public ICollection<string> RoleNames { get; set; }
    }//end class
}//end namespace
