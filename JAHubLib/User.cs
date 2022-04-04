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
        public string Password { set; get; }
        public string Email { set; get; } 
        
        
        public UserRole UserRole { get; set; }
        
        public void WriteToDatabase()
        {
            
            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                // To avoid the SqlException, put User into square brackets, like [User]
                String command = "INSERT INTO [User] (FirstName, MiddleName, LastName, " +
                    "EmailAddress, Password, UserRole) " +
                    "VALUES (@firstName, @middleName" +
                    ", @lastName, @email, @password, @userRole)";

                SqlCommand writeToDb = new SqlCommand(command, connection);
                // The SqlParameters probably aren't necessary, i thought they would fix the problem

                // First Name
                SqlParameter firstName = new SqlParameter();
                firstName.ParameterName = "firstName";
                firstName.SqlDbType = System.Data.SqlDbType.VarChar;
                firstName.Direction = System.Data.ParameterDirection.Input;
                firstName.Value = this.FirstName;
                writeToDb.Parameters.Add(firstName);

                // Middle Name
                SqlParameter middleName = new SqlParameter();
                middleName.ParameterName = "middleName";
                middleName.SqlDbType = System.Data.SqlDbType.VarChar;
                middleName.Direction = System.Data.ParameterDirection.Input;
                middleName.Value = this.MiddleName;
                writeToDb.Parameters.Add(middleName);

                // Last Name
                SqlParameter lastName = new SqlParameter();
                lastName.ParameterName = "lastName";
                lastName.SqlDbType = System.Data.SqlDbType.VarChar;
                lastName.Direction = System.Data.ParameterDirection.Input;
                lastName.Value = this.LastName;
                writeToDb.Parameters.Add(lastName);

                // Email Address
                SqlParameter email = new SqlParameter();
                email.ParameterName = "email";
                email.SqlDbType = System.Data.SqlDbType.VarChar;
                email.Direction = System.Data.ParameterDirection.Input;
                email.Value = this.Email;
                writeToDb.Parameters.Add(email);

                // Password
                SqlParameter password = new SqlParameter();
                password.ParameterName = "password";
                password.SqlDbType = System.Data.SqlDbType.VarChar;
                password.Direction = System.Data.ParameterDirection.Input;
                password.Value = this.Password;
                writeToDb.Parameters.Add(password);

                // User Role
                SqlParameter userRole = new SqlParameter();
                userRole.ParameterName = "userRole";
                userRole.SqlDbType = System.Data.SqlDbType.Int;
                userRole.Direction = System.Data.ParameterDirection.Input;
                userRole.Value = (int)this.UserRole;
                writeToDb.Parameters.Add(userRole);

                writeToDb.ExecuteNonQuery();

                connection.Close();
            }
        }

        public void ReadFromDatabase(int userId)
        {
            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();
                
                String command = $"SELECT * FROM [USER] WHERE ID={userId}";

                SqlCommand getRecord = new SqlCommand(command, connection);

                SqlDataReader reader = getRecord.ExecuteReader();

                while (reader.Read())
                {
                    UserID = userId;
                    FirstName = reader["FirstName"].ToString();
                    MiddleName = reader["MiddleName"].ToString();
                    LastName = reader["LastName"].ToString();
                    Email = reader["EmailAddress"].ToString();
                    Password = reader["Password"].ToString();
                    UserRole = (UserRole)reader["UserRole"];
                }

                connection.Close();
            }
        }
        
    }
}
