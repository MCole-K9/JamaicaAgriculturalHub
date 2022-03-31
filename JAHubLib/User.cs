﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAHubLib
{
    public class User
    {

        public int UserID { set; get; }
        public string FirstName { set; get; }
        public string MiddleName { set; get; }
        public string LastName { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public string Email { set; get; } 
        
        public UserRole UserRole { get; set; }
        
        public void WriteToDatabase()
        {
            
            
            // open connection
            // create the command
            // run the command
            // close the connection
        }
    }
}
