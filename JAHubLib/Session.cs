using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
        static UserRole _userRole = UserRole.NotLoggedIn;
        static int _userId;
        static String _name;

        // K.S.: may want to add {FirstName} {LastName} here to make that always accessible, not sure
        // yet
        public static UserRole UserRole => _userRole;
        public static int UserId => _userId;

        public static String Name => _name;


        public static PasswordResult Login(String email, String password)
        {

            // K.S.: This is just to make sure that you can't access login twice without first loggin out
            // but it shouldn't really matter
            //if (_userRole != UserRole.NotLoggedIn)
            //{
            //    return PasswordResult.NoMatchingCredentials;
            //}

            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                string command = "SELECT ID, EmailAddress, FirstName, LastName, Password, UserRole FROM [User] WHERE " +
                    $"EmailAddress = '{email}'";

                SqlCommand checkCredentials = new SqlCommand(command, connection);

                SqlDataReader reader = checkCredentials.ExecuteReader();

                PasswordResult result = new PasswordResult();

                if (reader.Read())
                {
                    if(reader["EmailAddress"].ToString() == email)
                    {
                        if(reader["Password"].ToString() == password)
                        {
                            result = PasswordResult.Success;

                            _userId = (int)reader["ID"];
                            _userRole = (UserRole)reader["UserRole"];
                            _name = (string)reader["FirstName"] + " " + (string)reader["LastName"];
                        }
                        else
                        {
                            result = PasswordResult.CredentialsIncorrect;
                        }
                    }
                    else
                    {
                        result = PasswordResult.NoMatchingCredentials;
                    }
                }
                else
                {
                    result = PasswordResult.NoMatchingCredentials;
                }

                connection.Close();

                return result;
            }
        }
        public static void LogOut()
        {
            _userRole = UserRole.NotLoggedIn;
            _userId = 0;
        }
    }
}
