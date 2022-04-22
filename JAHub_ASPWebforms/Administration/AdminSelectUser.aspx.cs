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
                tblUsers.Columns.Clear();
                tblUsers.AutoGenerateColumns = false;

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
                btfSelectUserColumn.ControlStyle.CssClass = "btn btn-default input-sm col-sm-3";

                // i can tell the new columns are being added infront of the old ones. also there's a ghost column
                // the id isn't showing, not sure why
                // may need to change where this is written to a different event


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
            // This is only going to work if you set the updatepanels and triggers correctly

            foreach (GridViewRow row in tblUsers.Rows)
            {
                if (!row.Cells[1].ToString().Contains(txtSearchBar.Text))
                {
                    row.Visible = false;
                }
            }
        }
    }
}