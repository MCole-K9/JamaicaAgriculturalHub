using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAHubLib;

namespace JAHub_ASPWebforms.Administration
{
    public partial class AdminEditUser : System.Web.UI.UserControl
    {
        public String UserName
        {
            get { return ViewState["EditUserName"] == null ? String.Empty: (String)ViewState["EditUserName"]; }
            set { ViewState["EditUserName"] = value; }
        }

        public int UserId
        {
            get {  return ViewState["EditUserId"] == null ? 0 : (int)ViewState["EditUserId"]; }
            set { ViewState["EditUserId"] = value; }
        }

        protected void Page_Init(object sender, EventArgs e)
        {
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
            User currentUser = new User();

            currentUser.UserID = UserId;
            currentUser.ReadFromDatabase(this.UserId);

            txtEmail.Text = currentUser.Email;
            txtPasswordOnce.Text = currentUser.Password;
            txtPasswordSecond.Text = currentUser.Password;
            nbNewUserName.FirstName = currentUser.FirstName;
            nbNewUserName.LastName = currentUser.LastName;
            nbNewUserName.MiddleName = currentUser.MiddleName;
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
                newUser.Password = txtPasswordOnce.Text;

                //newUser.UpdateUserRecord();

                isWriteSuccessful = true;
            }

            if (isWriteSuccessful)
            {
                lblSubmitTitle.Text = "Result Successful";
                lblSubmitText.Text = $"Successfully modified record for {newUser.FirstName} {newUser.LastName}.";

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
            if (txtPasswordOnce.Text == txtPasswordSecond.Text)
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