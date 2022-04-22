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
            if(tblUsers.DataSource == null)
            {
                DataTable dtAllusers = Admin.GetUserDataTable();
                tblUsers.DataSource = dtAllusers;

                // Creating the BoundFields

                // this column isn't showing for some reason
                BoundField bfIdColumn = new BoundField();
                bfIdColumn.DataField = "ID";
                bfIdColumn.HeaderText = "ID";

                // these columns are repeating for some reason
                BoundField bfNameColumn = new BoundField();
                bfIdColumn.DataField = "Name";
                bfIdColumn.HeaderText = "Name";

                BoundField bfUserRoleColumn = new BoundField();
                bfUserRoleColumn.DataField = "User Role";
                bfUserRoleColumn.HeaderText = "User Role";

                ButtonField btfSelectUserColumn = new ButtonField();
                btfSelectUserColumn.ButtonType = ButtonType.Button;
                btfSelectUserColumn.CommandName = "SelectUser";
                btfSelectUserColumn.Text = "Select User";
                


                // Adding the BoundFields and Buttonfield to the Table
                tblUsers.Columns.Add(bfIdColumn);
                tblUsers.Columns.Add(bfNameColumn);
                tblUsers.Columns.Add(bfUserRoleColumn);
                tblUsers.Columns.Add(btfSelectUserColumn);
                tblUsers.DataBind();
            }
            
        }

        protected void btnClearSearchBar_Click(object sender, EventArgs e)
        {
            txtSearchBar.Text = "";
        }

        protected void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            // foreach row and hide it if it doesn't contain the string, this may require turning off some feature or another
        }
    }
}