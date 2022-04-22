using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAHubLib;
using JAHub_ASPWebforms;
using System.Data;

namespace JAHub_ASPWebforms.Administration
{
    public partial class AdminSelectUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dtAllusers = Admin.GetUserDataTable();
            tblUsers.DataSource = dtAllusers;
            // Create the columns
            // Make sure they work
            // make sure they pass the right references and such to wherever
        }
    }
}