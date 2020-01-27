///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 3
//	File Name:		DbRoleRepository.cs
//	Course:			CSCI 3110-001 -Advanced Web
//	Author:			Cory Moore, moorecs1@etsu.edu, Department of Computing, East Tennessee State University
//	Created:		Thursday November 10th 2019
//	Copyright:		Cory Moore, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Groliapp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Groliapp.Services
{
    /// <summary>
    /// This acts as an instance of the repository for User Roles. 
    /// </summary>
    public class DbRoleRepository : IRoleRepository
    {
        /// <summary>
        /// Private field to inject the DbContext into the Constructor. 
        /// </summary>
        private ApplicationDbContext _db;
        /// <summary>
        /// Constructor for the Role repository. 
        /// </summary>
        /// <param name="db"></param>
        public DbRoleRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        /// <summary>
        /// This method reads all the roles in the database, and
        /// returns them as a "queryable" instance. 
        /// </summary>
        /// <returns></returns>
        public IQueryable<IdentityRole> ReadAll()
        {
            return _db.Roles ;
        }
    }//end class
}//end namespace
