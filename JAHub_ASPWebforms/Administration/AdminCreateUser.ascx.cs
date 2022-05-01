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
        private int currentIndex = 0;

        protected override void OnInit(EventArgs e)
        {
            Page.RegisterRequiresControlState(this);
            base.OnInit(e);
        }

        protected override object SaveControlState()
        {
            return currentIndex == 0 ? null : (object)currentIndex;
        }

        protected override void LoadControlState(object state)
        {
            if(state != null)
            {
                currentIndex = (int)state;
            }
        }

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

            String scriptString = /*"<script type=\"text/javascript\">" +*/
                "function RaiseSubmitModal(){" +
                "$('#submitModal').modal('show');}" +
                "function CloseSubmitModal(){" +
                "$('#submitModal').modal('hide');}"
                /*"</script>"*/;

            ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "CreateUserModal", scriptString, true);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (IsPostBack)
            //{
            //    Page.Validate("CreateNewUserGroup");
            //}



        }

        protected void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkShowPassword.Checked)
            {
                chkShowPassword.Checked = true;
            }

            if (chkShowPassword.Checked == true)
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

            Page.Validate();

            if (Page.IsValid)
            {
                newUser.FirstName = nbNewUserName.FirstName;
                newUser.LastName = nbNewUserName.LastName;
                newUser.MiddleName = nbNewUserName.MiddleName;
                newUser.Email = txtEmail.Text;
                newUser.UserRole = (UserRole)ddlUserRole.SelectedIndex;
                newUser.Password = txtPasswordOnce.Text;

                //newUser.WriteToDatabase();

                isWriteSuccessful = true;
            }

            if (isWriteSuccessful)
            {
                lblSubmitTitle.Text = "Result Successful";
                lblSubmitText.Text = $"Successfully created record for {newUser.FirstName} {newUser.LastName}.";

                ScriptManager.RegisterStartupScript(this, this.GetType(), "raiseSubmit", "RaiseSubmitModal()", true);
            }
            else
            {
                lblSubmitTitle.Text = "Result Unsuccessful";
                lblSubmitText.Text = "One or more field(s) is not valid. Please correct these fields and resubmit.";

                ScriptManager.RegisterStartupScript(this, this.GetType(), "raiseSubmitError", "RaiseSubmitModal()", true);
            }

        }

        protected void cusPasswordSecond_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if(txtPasswordOnce.Text == txtPasswordSecond.Text && !String.IsNullOrEmpty(txtPasswordSecond.Text))
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