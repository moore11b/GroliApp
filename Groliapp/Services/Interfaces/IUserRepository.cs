///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 3
//	File Name:		IUserRepository.cs
//	Course:			CSCI 3110-001 -Advanced Web
//	Author:			Cory Moore, moorecs1@etsu.edu, Department of Computing, East Tennessee State University
//	Created:		Thursday November 10th 2019
//	Copyright:		Cory Moore, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using Groliapp.Models;
using Groliapp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Groliapp.Services.Interfaces
{
    /// <summary>
    /// This is the interface for the user repository.
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Reads all the users in the database. 
        /// </summary>
        /// <returns></returns>
        Task<IQueryable<ApplicationUser>> ReadAllAsync();
        /// <summary>
        /// Finds a user by the user's id.  Returns the instance 
        /// of the user as an async task.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ApplicationUser> ReadAsync(string username);
        /// <summary>
        /// Assigns a role to the user. (If required)
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="roleName"></param>
        /// <returns></returns>
        Task<bool> AssignRoleAsync(string userName, string roleName);
        /// <summary>
        /// Finds a user by an email address.  Returns the instance 
        /// of the user as an async task. 
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        Task<ApplicationUser> ReadAsyncByEmail(string email);

    }
}
