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
using System.Runtime;

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
            
            // Assigning the data source here
            dgvUserInformation.DataSource = Admin.GetUserDataTable();
            dgvUserInformation.AllowUserToAddRows = false;

            // This creates the column for the "Select User" buttons
            DataGridViewButtonColumn selectUserButtonColumn = new DataGridViewButtonColumn();
            selectUserButtonColumn.Text = "Select User";
            selectUserButtonColumn.UseColumnTextForButtonValue = true;
            selectUserButtonColumn.DataPropertyName = "UserID";

            // This creates the column for the "ID" Section
            DataGridViewColumn idViewColumn = new DataGridViewColumn();
            idViewColumn.DefaultCellStyle = new DataGridViewCellStyle();
            idViewColumn.CellTemplate = new DataGridViewTextBoxCell();
            idViewColumn.Name = "ID";
            idViewColumn.DataPropertyName = "UserID";

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
                foreach(DataGridViewRow row in dgvUserInformation.Rows)
                {
                    row.Visible = true;
                }
            }
            else
            {
                foreach(DataGridViewRow row in dgvUserInformation.Rows)
                {
                    dgvUserInformation.CurrentCell = null;
                    String value = row.Cells[1].Value.ToString();

                    if (value.Contains(txtSearchBox.Text))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
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

        private void btnClearSearchTerm_Click(object sender, EventArgs e)
        {
            // All this does is clear the search term, the TextChanged event in txtSearchBox should
            // do the rest
            txtSearchBox.Text = "";
        }
    }
}
