using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAHub_ASPWebforms.Administration;

namespace JAHub_ASPWebforms
{
    public partial class AdministrationPage : System.Web.UI.Page
    {
        int UserID;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(phAdministration.Controls.Count == 0)
            {
                AdminSelectUser selectUser = new AdminSelectUser();
                selectUser.UserSelected += new EventHandler<UserSelectEventArgs>(SelectUser_UserSelected);
            }

                
        }

        public void SelectUser_UserSelected (object sender, UserSelectEventArgs e)
        {
            this.lblCurrentUser.Text = $"{e.UserFullName} (ID: {e.UserID}; Role: {e.UserRole})";
            this.UserID = e.UserID;
        }
    }
}