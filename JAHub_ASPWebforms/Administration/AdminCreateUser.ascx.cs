using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using JAHubLib;
using JAHub_ASPWebforms.Verification;

namespace JAHub_ASPWebforms.Administration
{
    public partial class AdminCreateUser : System.Web.UI.UserControl
    {
        protected void Page_Init(object sender, EventArgs e)
        {
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

            ddlUserRole.DataValueField = "Id";
            ddlUserRole.DataTextField = "UserRole";
            ddlUserRole.DataSource = userRoleTable;
            ddlUserRole.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            // Part of me wants to move this to the Init, since it really shouldn't change and doesn't need viewstate
            
            
            

        }

        protected void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // This causes postback in a way that comes off of this page and opens selectuser. why?
            if (chkShowPassword.Checked)
            {
                txtPasswordOnce.TextMode = TextBoxMode.SingleLine;
                txtPasswordSecond.TextMode = TextBoxMode.SingleLine;
            }
            else
            {
                txtPasswordOnce.TextMode = TextBoxMode.Password;
                txtPasswordSecond.TextMode = TextBoxMode.Password;
            }
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            bool isWriteSuccessful = false;

            if (Page.IsValid)
            {
                newUser.FirstName = nbNewUserName.FirstName;
                newUser.LastName = nbNewUserName.LastName;
                newUser.MiddleName = nbNewUserName.MiddleName;
                newUser.Email = txtEmail.Text;
                newUser.UserRole = (UserRole)ddlUserRole.SelectedIndex;
                newUser.Password = txtPasswordOnce.Text;

                newUser.WriteToDatabase();

                isWriteSuccessful = true;
            }

            if (isWriteSuccessful)
            {
                lblSubmitTitle.Text = "Result Successful";
                lblSubmitText.Text = $"Successfully created record for {newUser.FirstName} {newUser.LastName}.";

                ScriptManager.RegisterStartupScript(this, this.GetType(), "submit", "RaiseSubmitModal()", true);
            }
            else
            {
                lblSubmitTitle.Text = "Result Unsuccessful";
                lblSubmitText.Text = "One or more field(s) is not valid. Please correct these fields and resubmit.";

                ScriptManager.RegisterStartupScript(this, this.GetType(), "submit", "RaiseSubmitModal()", true);
            }

        }

        protected void cusPasswordSecond_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if(txtPasswordOnce.Text == txtPasswordSecond.Text)
            {
                args.IsValid = true;
            }
            else
            {
                cusPasswordSecond.Text = "Passwords must match!";
                args.IsValid = false;
            }
        }

        protected void cusPasswordOnce_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (String.IsNullOrEmpty(txtPasswordOnce.Text))
            {
                cusPasswordOnce.ErrorMessage = "Field cannot be blank";
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }

        }
    }
}