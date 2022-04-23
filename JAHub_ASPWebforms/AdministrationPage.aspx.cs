using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAHub_ASPWebforms.Administration;
using System.Data;
using System.Data.SqlClient;
using JAHubLib;

namespace JAHub_ASPWebforms
{
    public partial class AdministrationPage : System.Web.UI.Page
    {
        int userID;
        protected void Page_Load(object sender, EventArgs e)
        {
            OpenSelectUserControl();
        }

        public void SelectUser_UserSelected (object sender, UserSelectEventArgs e)
        {
            this.lblCurrentUser.Text = $"{e.UserFullName} (ID: {e.UserID}; Role: {e.UserRole})";
            this.userID = e.UserID;

            ScriptManager.RegisterStartupScript(this, this.GetType(), "useroptions", "OpenUserOptions()", true);
        }

        protected void btnSelectUser_Click(object sender, EventArgs e)
        {
            OpenSelectUserControl();
        }

        protected void btnCreateNewUser_Click(object sender, EventArgs e)
        {
            // scrub the last page
            // open the new one
        }

        protected void btnDeleteUser_Click(object sender, EventArgs e)
        {
            // All this does is bring up the modal where the user can choose to delete or not
            ScriptManager.RegisterStartupScript(this, this.GetType(), "idk", "OpenModal()", true);

        }

        protected void btnEditUser_Click(object sender, EventArgs e)
        {

        }

        protected void btnViewModeration_Click(object sender, EventArgs e)
        {

        }

        protected void OpenSelectUserControl()
        {
            foreach (Control control in phAdministration.Controls)
            {
                if (control is AdminSelectUser)
                {
                    // do nothing;
                }
                else
                {
                    phAdministration.Controls.Remove(control);
                }
            }

            if (phAdministration.Controls.Count == 0)
            {
                AdminSelectUser selectUser = (AdminSelectUser)LoadControl("~/Administration/AdminSelectUser.ascx");
                selectUser.UserSelected += new EventHandler<UserSelectEventArgs>(SelectUser_UserSelected);

                phAdministration.Controls.Add(selectUser);
            }
            
        }

        protected void btnDeleteYes_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                String command = $"DELETE FROM [User] WHERE ID = {userID};";

                SqlCommand deleteRecord = new SqlCommand(command, connection);

                deleteRecord.ExecuteNonQuery();

                connection.Close();
            }

            // This should re-hide the options
            ScriptManager.RegisterStartupScript(this, this.GetType(), "hideUserOption", "CloseUserOption()", true);

            if (phAdministration.Controls.Count > 0)
            {
                if(!(phAdministration.Controls[0] is AdminSelectUser))
                {
                    phAdministration.Controls.Clear();
                    OpenSelectUserControl();
                }
            }
            else
            {
                OpenSelectUserControl();
            }

            lblCurrentUser.Text = "Current User: none selected";
        }

        protected void btnDeleteNo_Click(object sender, EventArgs e)
        {

        }
    }
}