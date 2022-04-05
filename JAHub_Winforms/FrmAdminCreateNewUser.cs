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
        FrmAdminContainer frmAdmin;

        public FrmAdminCreateNewUser(FrmAdminContainer admin)
        {
            InitializeComponent();
            TopLevel = false;

            frmAdmin = admin;
        }

        private void FrmAdminCreateNewUser_Load(object sender, EventArgs e)
        {
            // This is just in case i have anything in the cmb already
            cmbUserRole.Items.Clear();

            // Creating a datacolumn for ID
            DataColumn idColumn = new DataColumn();
            idColumn.ColumnName = "Id";
            idColumn.DataType = typeof(UserRole);

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
            if (txtPasswordFirstEntry.Text == "")
            {
                errCreateNewUser.SetIconAlignment(txtPasswordFirstEntry, ErrorIconAlignment.MiddleRight);
                errCreateNewUser.SetError(txtPasswordFirstEntry, "Password must be entered");
                isPasswordValid = false;

                return;
            }
            else if (txtPasswordSecondEntry.Text != txtPasswordFirstEntry.Text)
            {
                errCreateNewUser.SetIconAlignment(txtPasswordSecondEntry, ErrorIconAlignment.MiddleRight);
                errCreateNewUser.SetError(txtPasswordSecondEntry, "Passwords must match");
                isPasswordValid = false;
            }
            else if (txtPasswordSecondEntry.Text == txtPasswordFirstEntry.Text)
            {
                errCreateNewUser.SetError(txtPasswordSecondEntry, "");
                isPasswordValid = true;
            }
        }

        private void btnSubmitRecord_Click(object sender, EventArgs e)
        {
            Boolean areEntriesValid = false;

            if (usrNameBlock1.IsBlockValid())
            {
                if (isEmailValid)
                {
                    if (usrNameBlock1.IsBlockValid())
                    {
                        if (isPasswordValid)
                        {
                            areEntriesValid = true;

                            User newUser = new User();

                            newUser.FirstName = usrNameBlock1.FirstName;
                            newUser.LastName = usrNameBlock1.LastName;
                            newUser.MiddleName = usrNameBlock1.MiddleName;

                            newUser.Email = txtEmail.Text.ToLower();
                            newUser.Password = txtPasswordFirstEntry.Text;

                            newUser.UserRole = (UserRole)cmbUserRole.SelectedValue;

                            newUser.WriteToDatabase();
                        }
                    }
                }
            }

            if (areEntriesValid == false)
            {
                MessageBox.Show("Cannot Create New User. One or More Errors Exist. Please fix them to" +
                    " Continue");
            }
            else
            {
                MessageBox.Show("Successfully created new record!");
            }
        }
    }
}
