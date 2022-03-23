using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAHubLib
{
    public enum UserRole
    {
        Admin = 0,
        Customer = 1,
        Farmer = 2,
        GrantOfficer = 3,
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

        // unsure whether or not i want this to return a boolean or nothing yet
        public static PasswordResult Login(int userId, String password)
        {
            // this is roughly where the query will go
            
            if (userId == 1)
            {
                if (password == "test")
                {
                    _userId = 1;
                    _userRole = UserRole.Admin;
                    
                    return PasswordResult.Success;
                }
            }
            else if (userId == 3)
            {
                return PasswordResult.CredentialsIncorrect;
            }

            // Basically:
            // - Take the username and password
            // - Check them against the database
            // - if successful, fill attributes for blahblah
            // - if unsuccessful, return false (maybe return a value indicating success/failure type?)

            return PasswordResult.NoMatchingCredentials;
        }
    }
}
