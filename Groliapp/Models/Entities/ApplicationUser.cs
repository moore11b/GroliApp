///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 3
//	File Name:		ApplicationUser.cs
//	Course:			CSCI 3110-001 -Advanced Web
//	Author:			Cory Moore, moorecs1@etsu.edu, Department of Computing, East Tennessee State University
//	Created:		Thursday November 10th 2019
//	Copyright:		Cory Moore, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Groliapp.Models.Entities
{
    /// <summary>
    /// This class represents a user that may use this application. 
    /// Implements the IdentityUser class. 
    /// </summary>
    public class ApplicationUser : IdentityUser
    {
        [NotMapped]
        public ICollection<string> Roles { get; set; }
        /// <summary>
        /// Shows in the user is assigned a specific rule as a boolean. 
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        public bool HasRole(string roleName)
        {
            return Roles.Any(r => r == roleName);
        }
    }//end class
}//end namespace
