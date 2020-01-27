///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 3
//	File Name:		DbUserRepository.cs
//	Course:			CSCI 3110-001 -Advanced Web
//	Author:			Cory Moore, moorecs1@etsu.edu, Department of Computing, East Tennessee State University
//	Created:		Thursday November 10th 2019
//	Copyright:		Cory Moore, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using Groliapp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Groliapp.Models;
using Groliapp.Data;
using Groliapp.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Groliapp.Services
{
    /// <summary>
    /// This class is the repository for Users of the Groli-App. 
    /// </summary>
    public class DbUserRepository : IUserRepository
    {
        private ApplicationDbContext _db;
        private UserManager<ApplicationUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        /// <summary>
        /// Constructor for a user entity. 
        /// </summary>
        /// <param name="db"></param>
        /// <param name="userManager"></param>
        /// <param name="roleManager"></param>
        public DbUserRepository(ApplicationDbContext db,
           UserManager<ApplicationUser> userManager,
           RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        /// <summary>
        /// Assigns a role to the user. (If required)
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="roleName"></param>
        /// <returns></returns>
        public async Task<bool> AssignRoleAsync(string userName, string roleName)
        {
            var user = await ReadAsync(userName);
            if (user != null)
            {
                if (!user.HasRole(roleName))
                {
                    await _userManager.AddToRoleAsync(user, roleName);
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Reads all the users in the database. 
        /// </summary>
        /// <returns></returns>
        public async Task<IQueryable<ApplicationUser>> ReadAllAsync()
        {
            var users = _db.Users;
            foreach (var user in users)
            {
                user.Roles = await _userManager.GetRolesAsync(user);
            }
            return users;
        }
        /// <summary>
        /// Finds a user by an email address.  Returns the instance 
        /// of the user as an async task. 
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> ReadAsyncByEmail(string email)
        {
            var user = await _db.Users.FirstOrDefaultAsync(u => u.Email == email);
            user.Roles = await _userManager.GetRolesAsync(user);
            return user;
        }
        /// <summary>
        /// Finds a user by the user's id.  Returns the instance 
        /// of the user as an async task.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> ReadAsync(string id)
        {
            var user = await _db.Users.FirstOrDefaultAsync(u => u.Id == id);
            user.Roles = await _userManager.GetRolesAsync(user);
            return user;
        }
    }//end class
}//end namespace
