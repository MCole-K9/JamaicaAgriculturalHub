using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using JAHubLib;

namespace JAHub_Winforms
{
    public partial class FrmAdminCreateNewUser : Form
    {
        public FrmAdminCreateNewUser()
        {
            InitializeComponent();
            TopLevel = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmAdminCreateNewUser_Load(object sender, EventArgs e)
        {
            // This is just in case i have anything in the cmb already
            cmbUserRole.Items.Clear();

            // Creating a datacolumn for ID
            DataColumn idColumn = new DataColumn();
            idColumn.ColumnName = "Id";
            idColumn.DataType = typeof(int);

            // Creating the datacolumn for userRole
            DataColumn userRoleColumn = new DataColumn();
            userRoleColumn.ColumnName = "UserRole";
            userRoleColumn.DataType = typeof(String);

            DataTable userRoleTable = new DataTable("User Roles");
            userRoleTable.Columns.Add(idColumn);
            userRoleTable.Columns.Add(userRoleColumn);

            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                String userTypeQuery = "SELECT * FROM UserRole";

                SqlCommand command = new SqlCommand(userTypeQuery, connection);

                SqlDataReader reader = command.ExecuteReader();



                while (reader.Read())
                {
                    DataRow row;

                    row = userRoleTable.NewRow();
                    row["Id"] = reader[0];
                    row["UserRole"] = reader[1];

                    userRoleTable.Rows.Add(row);
                }

                connection.Close();
            }

            cmbUserRole.DataSource = userRoleTable;
            cmbUserRole.DisplayMember = "UserRole";
            cmbUserRole.ValueMember = "Id";
        }
    }
}
