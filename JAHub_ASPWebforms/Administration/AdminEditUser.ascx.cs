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
            get
            {
                return ViewState["EditUserId"] == null ? 0 : (int)ViewState["EditUserId"];
            }
            set
            {
                ViewState["EditUserId"] = value;
            }
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                User currentUser = new User();

                currentUser.UserID = UserId;
                currentUser.ReadFromDatabase(this.UserId);

                txtEmail.Text = currentUser.Email;
                txtPasswordOnce.Text = currentUser.Password;
                txtPasswordSecond.Text = currentUser.Password;
                // i don't know how to get the nameblock
            }
            
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
                newUser.Password = txtPasswordOnce.Text;

                //newUser.WriteToDatabase();

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