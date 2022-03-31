﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAHubLib
{
    // Rewrite to fit with database
    public enum UserRole
    {
        Admin = 1,
        Customer = 2,
        Farmer = 3,
        GrantOfficer = 4,
        NotLoggedIn = 5,
    }

    public enum PasswordResult
    {
        NoMatchingCredentials = 0,
        CredentialsIncorrect = 1,
        Success = 2,
    }

    public static class Session
    {
        /* This should basically keep space for a method that checks the details
         * entered into the login, then if correct makes a readonly property of role and 
         * 
         */

        static UserRole _userRole;
        static int _userId;

        // It's never necessary to change these upon a successful login, the object manages this
        public static UserRole UserRole => _userRole;
        public static int UserId => _userId;


        public static PasswordResult Login(int userId, String password)
        {
            // this is roughly where the query will go, inside of a using(){} block probably

            // should probably prevent the possibility of changing this during normal operation

            // shelving this for now, but i'll deal with it tomorrow
            //if (_userRole != UserRole.NotLoggedIn)
            //{

            //}

            
            if (userId == 1)
            {
                if (password == "test")
                {
                    _userId = 1;
                    _userRole = UserRole.Admin;
                    
                    return PasswordResult.Success;
                }

                return PasswordResult.CredentialsIncorrect;
            }
            else if (userId == 2)
            {
                if (password == "test")
                {
                    _userId = 2;
                    _userRole = UserRole.Farmer;

                    return PasswordResult.Success;
                }

                return PasswordResult.CredentialsIncorrect;
            }
            else
            {
                return PasswordResult.NoMatchingCredentials;
            }
        }

        // will actually 
        public static void LogOut()
        {
            _userRole = UserRole.NotLoggedIn;
            _userId = 0;

            // close all forms
            // freeze all controls (however that works)
            // bring back up a Login screen
        }
    }
}
