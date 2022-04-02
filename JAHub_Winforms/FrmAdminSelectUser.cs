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
        FrmAdminContainer _parent;
        DataTable allUsersSelection;

        public FrmAdminSelectUser(FrmAdminContainer parent)
        {
            InitializeComponent();
            TopLevel = false;
            _parent = parent;
        }

        private void FrmAdminSelectUser_Load(object sender, EventArgs e)
        {
            dgvUserInformation.Columns.Clear();
            dgvUserInformation.Rows.Clear();
            dgvUserInformation.AutoGenerateColumns = false;
            
            allUsersSelection = new DataTable();

            DataColumn idDataColumn = new DataColumn();
            idDataColumn.ColumnName = "ID";

            DataColumn nameDataColumn = new DataColumn();
            nameDataColumn.ColumnName = "Name";

            DataColumn roleDataColumn = new DataColumn();
            roleDataColumn.ColumnName = "User Role";

            DataColumn selectDataColumn = new DataColumn();
            selectDataColumn.ColumnName = "Select User";

            allUsersSelection.Columns.Add(idDataColumn);
            allUsersSelection.Columns.Add(nameDataColumn);
            allUsersSelection.Columns.Add(roleDataColumn);
            allUsersSelection.Columns.Add(selectDataColumn);

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
                        reader["LastName"].ToString(), (UserRole)reader["UserRole"], (int)reader["ID"]);
                }

                connection.Close();
            }
            
            // Assigning the data source here
            dgvUserInformation.DataSource = allUsersSelection;

            // This creates the column for the "Select User" buttons
            DataGridViewButtonColumn selectUserButtonColumn= new DataGridViewButtonColumn();
            selectUserButtonColumn.Text = "Select User";
            selectUserButtonColumn.UseColumnTextForButtonValue = true;
            selectUserButtonColumn.DataPropertyName = "ID";

            // This creates the column for the "ID" Section
            DataGridViewColumn idViewColumn = new DataGridViewColumn();
            idViewColumn.DefaultCellStyle = new DataGridViewCellStyle();
            idViewColumn.CellTemplate = new DataGridViewTextBoxCell();
            idViewColumn.Name = "ID";
            idViewColumn.DataPropertyName = "ID";

            // This creates the column for the "Name" Section
            DataGridViewColumn nameViewColumn = new DataGridViewColumn();
            nameViewColumn.DefaultCellStyle = new DataGridViewCellStyle();
            nameViewColumn.CellTemplate = new DataGridViewTextBoxCell();
            nameViewColumn.Name = "Name";
            nameViewColumn.DataPropertyName = "Name";

            // This creates the column for the "User Role" Section
            DataGridViewColumn userRoleViewColumn = new DataGridViewColumn();
            userRoleViewColumn.DefaultCellStyle = new DataGridViewCellStyle();
            userRoleViewColumn.CellTemplate = new DataGridViewTextBoxCell();
            userRoleViewColumn.Name = "User Role";
            userRoleViewColumn.DataPropertyName = "User Role";


            // This adds all of the columns to the DGV
            dgvUserInformation.Columns.Add(idViewColumn);
            dgvUserInformation.Columns.Add(nameViewColumn);
            dgvUserInformation.Columns.Add(userRoleViewColumn);
            dgvUserInformation.Columns.Add(selectUserButtonColumn);
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchBox.Text == "")
            {
                // DGV doesn't contain a RowFilter property, datatable doesn't either
                // so i need some way of doing that that doesn't probably result in 
                // rewriting a bunch of code

                // This would just reset the filtering
            }
            else
            {
                // Here is where the filtering would actually happen
            }
        }

        private void dgvUserInformation_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // this just stops the user from being able to break the program by clicking the empty line at the bottom
            if (dgvUserInformation[e.ColumnIndex, e.RowIndex].Value.ToString() == "")
            {
                return;
            }
            // All the buttons are in column 3, so
            if (e.ColumnIndex == 3)
            {
                // This sends the userId, Name, and Role of the user
                _parent.SetCurrentUser(Int32.Parse(dgvUserInformation[0, e.RowIndex].Value.ToString()), 
                    dgvUserInformation[1, e.RowIndex].Value.ToString(), 
                    dgvUserInformation[2, e.RowIndex].Value.ToString());
            }
        }
    }
}
