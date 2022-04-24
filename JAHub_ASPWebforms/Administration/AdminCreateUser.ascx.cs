using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using JAHubLib;

namespace JAHub_ASPWebforms.Administration
{
    public partial class AdminCreateUser : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlUserRole.DataSource = Admin.GetUserRoles();
            ddlUserRole.DataBind();
            ddlUserRole.DataValueField = "Id";
            ddlUserRole.DataTextField = "UserRole";
        }

        protected void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
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

            // for some reason this isn't accessible
            //updPassword.Update();
            
        }

    }
}