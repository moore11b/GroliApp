///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 3
//	File Name:		GroceryItemHub.cs
//	Course:			CSCI 3110-001 -Advanced Web
//	Author:			Cory Moore, moorecs1@etsu.edu, Department of Computing, East Tennessee State University
//	Created:		Thursday November 10th 2019
//	Copyright:		Cory Moore, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Groliapp.Services.Hubs
{
    /// <summary>
    /// Used for Signalr tasks and operations.
    /// </summary>
    public class GroceryItemHub : Hub 
    {
        public async Task SendToAll(string message)
        {
            await Clients.All.SendAsync("GroceryItemUpdated", message);
            await Clients.All.SendAsync("GroceryPermissionsUpdated", message);
        }
    }//end class
}//end namespace
