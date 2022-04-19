using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JAHub_ASPWebforms.Account
{
    public partial class usrNavbarAccountLogout : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblUserInformation.Text = $"{Session["FirstName"]} {Session["LastName"]} (UserID: {Session["UserId"]}; Role: {Session["UserRole"]}";
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();

            Response.Redirect(Request.RawUrl);
        }
    }
}