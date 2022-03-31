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
using JAHub_Winforms.Verification;

namespace JAHub_Winforms
{
    public partial class FrmAdminCreateNewUser : Form
    {
        bool isEmailValid;
        bool isPasswordValid;

        public FrmAdminCreateNewUser()
        {
            InitializeComponent();
            TopLevel = false;
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

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.IndexOf("@") > -1)
            {
                if (txtEmail.Text.IndexOf(".", txtEmail.Text.IndexOf("@")) > txtEmail.Text.IndexOf("@"))
                {
                    errCreateNewUser.SetError(txtEmail, "");

                    isEmailValid = true;
                }
            }
            else if (txtEmail.Text == "")
            {
                errCreateNewUser.SetIconAlignment(txtEmail, ErrorIconAlignment.MiddleRight);
                errCreateNewUser.SetError(txtEmail, "Field Cannot be Blank");

                isEmailValid = false;
            }
            else
            {

                errCreateNewUser.SetIconAlignment(txtEmail, ErrorIconAlignment.MiddleRight);
                errCreateNewUser.SetError(txtEmail, "Must be a valid email, e.g. someone@example.com");

                isEmailValid = false;
            }
        }

        private void txtPasswordFirstEntry_Validating(object sender, CancelEventArgs e)
        {
            if (txtPasswordFirstEntry.Text == "")
            {
                errCreateNewUser.SetIconAlignment(txtPasswordFirstEntry, ErrorIconAlignment.MiddleRight);
                errCreateNewUser.SetError(txtPasswordFirstEntry, "Password must be entered");

                return;
            }
            else
            {
                errCreateNewUser.SetError(txtPasswordFirstEntry, "");
            }
        }

        private void txtPasswordSecondEntry_Validating(object sender, CancelEventArgs e)
        {
            // basically:
            // - check to see if the user left the field blank
            //  - if blank, tell them
            // - if not blank, check to see if the values match. if they do cool (set isPasswordValid=true)
            //  - if not, tell them as such
            if (txtPasswordFirstEntry.Text == "")
            {
                errCreateNewUser.SetIconAlignment(txtPasswordFirstEntry, ErrorIconAlignment.MiddleRight);
                errCreateNewUser.SetError(txtPasswordFirstEntry, "Password must be entered");

                return;
            }
            else if (txtPasswordSecondEntry.Text != txtPasswordFirstEntry.Text)
            {
                errCreateNewUser.SetIconAlignment(txtPasswordSecondEntry, ErrorIconAlignment.MiddleRight);
                errCreateNewUser.SetError(txtPasswordSecondEntry, "Passwords must match");
            }
            else
            {
                errCreateNewUser.SetError(txtPasswordSecondEntry, "");
            }
        }

        private void btnSubmitRecord_Click(object sender, EventArgs e)
        {
            // basically:
            // - get validity of various controls
            // - if all = valid, store the information in a user obj, then the user obj to write to db
            // - if not valid, raise messagebox that says "Yo you fucked up g, fix this"
        }
    }
}
