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

            // Creating the BoundFields

            BoundField bfIdColumn = new BoundField();
            bfIdColumn.DataField = "ID";
            bfIdColumn.HeaderText = "ID";

            BoundField bfNameColumn = new BoundField();
            bfIdColumn.DataField = "Name";
            bfIdColumn.HeaderText = "Name";

            BoundField bfUserRoleColumn = new BoundField();
            bfUserRoleColumn.DataField = "UserRole";
            bfUserRoleColumn.HeaderText = "User Role";

            // need to create a Template field for the selectUser  parts
            // It needs to have a method that gets the corresponding value of ID in that row
            // When it gets that method, it needs to fire some kind of event that produces the necessary values
            // that another form can add its own method to


            // Adding the BoundFields (and TemplateField) to the Table
            tblUsers.Columns.Add(bfIdColumn);
            tblUsers.Columns.Add(bfNameColumn);
            tblUsers.Columns.Add(bfUserRoleColumn);
        }
    }
}