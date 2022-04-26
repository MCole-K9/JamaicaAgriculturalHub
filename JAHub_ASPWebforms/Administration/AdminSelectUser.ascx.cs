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
    public partial class AdminSelectUser : System.Web.UI.UserControl
    {
        public event EventHandler<UserSelectEventArgs> UserSelected;

        public AdminSelectUser()
        {
            //tblUsers.Columns.Clear();
            //tblUsers.AutoGenerateColumns = false;

            //DataTable dtAllusers = Admin.GetUserDataTable();
            //tblUsers.DataSource = dtAllusers;

            //// Creating the BoundFields
            //BoundField bfIdColumn = new BoundField();
            //bfIdColumn.DataField = "UserID";
            //bfIdColumn.HeaderText = "ID";
            //bfIdColumn.ControlStyle.CssClass = "text input-sm col-sm-2";

            //BoundField bfNameColumn = new BoundField();
            //bfNameColumn.DataField = "UserFullName";
            //bfNameColumn.HeaderText = "Name";

            //BoundField bfUserRoleColumn = new BoundField();
            //bfUserRoleColumn.DataField = "User Role";
            //bfUserRoleColumn.HeaderText = "User Role";

            //ButtonField btfSelectUserColumn = new ButtonField();
            //btfSelectUserColumn.ButtonType = ButtonType.Button;
            //btfSelectUserColumn.CommandName = "SelectUser";
            //btfSelectUserColumn.Text = "Select User";
            //btfSelectUserColumn.ControlStyle.CssClass = "btn btn-default input-sm col-sm-3";

            //// Adding the BoundFields and Buttonfield to the Table
            //tblUsers.Columns.Add(bfIdColumn);
            //tblUsers.Columns.Add(bfNameColumn);
            //tblUsers.Columns.Add(bfUserRoleColumn);
            //tblUsers.Columns.Add(btfSelectUserColumn);
            //tblUsers.DataBind();
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            tblUsers.Columns.Clear();
            tblUsers.AutoGenerateColumns = false;

            DataTable dtAllusers = Admin.GetUserDataTable();
            tblUsers.DataSource = dtAllusers;

            // Creating the BoundFields
            BoundField bfIdColumn = new BoundField();
            bfIdColumn.DataField = "UserID";
            bfIdColumn.HeaderText = "ID";
            bfIdColumn.ControlStyle.CssClass = "text input-sm col-sm-2";

            BoundField bfNameColumn = new BoundField();
            bfNameColumn.DataField = "UserFullName";
            bfNameColumn.HeaderText = "Name";

            BoundField bfUserRoleColumn = new BoundField();
            bfUserRoleColumn.DataField = "User Role";
            bfUserRoleColumn.HeaderText = "User Role";

            ButtonField btfSelectUserColumn = new ButtonField();
            btfSelectUserColumn.ButtonType = ButtonType.Button;
            btfSelectUserColumn.CommandName = "SelectUser";
            btfSelectUserColumn.Text = "Select User";
            btfSelectUserColumn.ControlStyle.CssClass = "btn btn-default input-sm col-sm-3";

            // Adding the BoundFields and Buttonfield to the Table
            tblUsers.Columns.Add(bfIdColumn);
            tblUsers.Columns.Add(bfNameColumn);
            tblUsers.Columns.Add(bfUserRoleColumn);
            tblUsers.Columns.Add(btfSelectUserColumn);
            tblUsers.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClearSearchBar_Click(object sender, EventArgs e)
        {
            txtSearchBar.Text = "";
        }

        protected void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearchBar.Text))
            {
                foreach (GridViewRow row in tblUsers.Rows)
                {
                    row.Visible = true;
                }
            }
            else
            {
                foreach (GridViewRow row in tblUsers.Rows)
                {
                    String value = row.Cells[1].ToString();

                    if (value.Contains(txtSearchBar.Text))
                    {
                        row.CssClass = "";
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }

        }

        protected void tblUsers_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "SelectUser")
            {
                int index = Convert.ToInt32(e.CommandArgument);

                UserSelectEventArgs args = new UserSelectEventArgs();

                args.UserRole = tblUsers.Rows[index].Cells[2].Text;

                args.UserFullName = tblUsers.Rows[index].Cells[1].Text;

                args.UserID = Convert.ToInt32(tblUsers.Rows[index].Cells[0].Text);

                if (UserSelected != null)
                {
                    UserSelected(this, args);
                }
            }
        }
    }


    // Doing this entirely because I don't know how classes relate to each other in ASP
    public class UserSelectEventArgs : EventArgs
    {
        public int UserID { get; set; }
        public string UserFullName { get; set; }
        public string UserRole { get; set; }
    }
}