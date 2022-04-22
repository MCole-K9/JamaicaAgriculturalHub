using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace JAHubLib
{
    public static class Admin
    {
        public static DataTable GetUserDataTable()
        {
            DataTable allUsers = new DataTable();

            DataColumn idDataColumn = new DataColumn();
            idDataColumn.ColumnName = "UserID";

            DataColumn nameDataColumn = new DataColumn();
            nameDataColumn.ColumnName = "Name";

            DataColumn roleDataColumn = new DataColumn();
            roleDataColumn.ColumnName = "User Role";

            DataColumn selectDataColumn = new DataColumn();
            selectDataColumn.ColumnName = "Select User";

            allUsers.Columns.Add(idDataColumn);
            allUsers.Columns.Add(nameDataColumn);
            allUsers.Columns.Add(roleDataColumn);
            allUsers.Columns.Add(selectDataColumn);

            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                String command = "SELECT ID, FirstName, LastName, UserRole" +
                    " FROM [User];";

                SqlCommand listUsersCommand = new SqlCommand(command, connection);

                SqlDataReader reader = listUsersCommand.ExecuteReader();

                while (reader.Read())
                {
                    allUsers.Rows.Add((int)reader["ID"], reader["FirstName"].ToString() + " " +
                        reader["LastName"].ToString(), (UserRole)reader["UserRole"], (int)reader["ID"]);
                }

                connection.Close();
            }

            return allUsers;
        }

    }
}
