using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                // Apparently this might require understanding what a sqlParameter is

                String command = $"INSERT INTO User (FirstName, MiddleName, LastName, " +
                    "EmailAddress, Password, UserRole) " +
                    $"VALUES ('{FirstName}', '{MiddleName}'" +
                    $", '{LastName}', '{Email}', '{Password}', {(int)UserRole})";

                SqlCommand writeToDb = new SqlCommand(command, connection);

                writeToDb.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
