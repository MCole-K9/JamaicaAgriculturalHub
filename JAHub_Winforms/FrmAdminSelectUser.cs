using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JAHubLib;
using System.Data.SqlClient;

namespace JAHub_Winforms
{
    public partial class FrmAdminSelectUser : Form
    {
        DataTable allUsersSelection;

        public FrmAdminSelectUser()
        {
            InitializeComponent();
            TopLevel = false;
        }

        private void FrmAdminSelectUser_Load(object sender, EventArgs e)
        {
            dgvUserInformation.Columns.Clear();
            dgvUserInformation.Rows.Clear();
            
            allUsersSelection = new DataTable();

            DataColumn idColumn = new DataColumn();
            idColumn.ColumnName = "ID";

            DataColumn nameColumn = new DataColumn();
            nameColumn.ColumnName = "Name";

            DataColumn roleColumn = new DataColumn();
            roleColumn.ColumnName = "User Role";

            DataColumn selectColumn = new DataColumn();
            selectColumn.ColumnName = "Select User";

            allUsersSelection.Columns.Add(idColumn);
            allUsersSelection.Columns.Add(nameColumn);
            allUsersSelection.Columns.Add(roleColumn);
            allUsersSelection.Columns.Add(selectColumn);

            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                String command = "SELECT ID, FirstName, LastName, UserRole" +
                    " FROM [User]";

                SqlCommand listUsersCommand = new SqlCommand(command, connection);

                SqlDataReader reader = listUsersCommand.ExecuteReader();

                while (reader.Read())
                {
                    allUsersSelection.Rows.Add((int)reader["ID"], reader["FirstName"].ToString() + " " +
                        reader["LastName"].ToString(), (UserRole)reader["UserRole"], new Button());

                    // Where do i add the thing for the button?
                }

                connection.Close();
            }
            
            dgvUserInformation.DataSource = allUsersSelection;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // This is roughly where the filtering will happen
            // but how do i actually filter anything lol
        }
    }
}
