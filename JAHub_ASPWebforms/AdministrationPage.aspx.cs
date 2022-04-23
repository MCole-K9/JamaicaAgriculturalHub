using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAHub_ASPWebforms.Administration;
using System.Data;
using System.Data.SqlClient;

namespace JAHub_ASPWebforms
{
    public partial class AdministrationPage : System.Web.UI.Page
    {
        int UserID;
        protected void Page_Load(object sender, EventArgs e)
        {
            OpenSelectUserControl();
        }

        public void SelectUser_UserSelected (object sender, UserSelectEventArgs e)
        {
            this.lblCurrentUser.Text = $"{e.UserFullName} (ID: {e.UserID}; Role: {e.UserRole})";
            this.UserID = e.UserID;
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


            //String message = "Are you sure you want to delete the account of" +
            //    lblNameValue.Text + " (ID: " + _userId.ToString() + ", Role: " +
            //    lblRoleValue.Text + ")";
            //const String caption = "Delete Account";

            //var result = MessageBox.Show(message, caption,
            //                             MessageBoxButtons.YesNo,
            //                             MessageBoxIcon.Question);


            //if (result == DialogResult.Yes)
            //{
            //    using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            //    {
            //        connection.Open();

            //        String command = $"DELETE FROM [User] WHERE ID = {_userId};";

            //        SqlCommand deleteRecord = new SqlCommand(command, connection);

            //        deleteRecord.ExecuteNonQuery();

            //        connection.Close();
            //    }

            //    //HideUserOptions();

            //    if (phAdministration.Controls.Count > 0)
            //    {
            //        //Form form = (Form)pnlFormHolder.Controls[0];

            //        //form.Close();
            //        //phAdministration.Controls.Clear();
            //    }

            //    OpenSelectUserControl();

            //    // these just empty the "Current User" section
            //    lblCurrentUser.Text = "Current User: none selected";
            //}


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
    }
}