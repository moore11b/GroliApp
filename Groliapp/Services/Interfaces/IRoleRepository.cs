///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 3
//	File Name:		IRoleRepository.cs
//	Course:			CSCI 3110-001 -Advanced Web
//	Author:			Cory Moore, moorecs1@etsu.edu, Department of Computing, East Tennessee State University
//	Created:		Thursday November 10th 2019
//	Copyright:		Cory Moore, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Groliapp.Services
{
  
    /// <summary>
    /// This is the interface for the user repository.
    /// </summary>
    public interface IRoleRepository
    {
        /// <summary>
        /// This method reads all the roles in the database, and
        /// returns them as a "queryable" instance. 
        /// </summary>
        /// <returns></returns>
        IQueryable<IdentityRole> ReadAll();
    }
}
