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
    public class UserGridView : GridView
    {
        public UserGridView()
        {
            GridView dataGrid = new GridView();

            dataGrid.Columns.Clear();
            dataGrid.AutoGenerateColumns = false;

            DataTable dtAllusers = Admin.GetUserDataTable();
            dataGrid.DataSource = dtAllusers;

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
            dataGrid.Columns.Add(bfIdColumn);
            dataGrid.Columns.Add(bfNameColumn);
            dataGrid.Columns.Add(bfUserRoleColumn);
            dataGrid.Columns.Add(btfSelectUserColumn);
            dataGrid.DataBind();
        }
    }


    public partial class AdministrationPage : System.Web.UI.Page
    {
        // Praying this works
        public int userID
        {
            get
            {
                return this.ViewState["userID"] == null ? 0 : (int)this.ViewState["userID"];
            }
            set
            {
                this.ViewState["userID"] = value;
            }
        }

        // This too
        public String userFullName { 
            get
            {
                return this.ViewState["userFullName"] == null ? "" : this.ViewState["userFullName"] as String;
            } 
            set 
            {
                this.ViewState["userFullName"] = value;
            } 
        }
        protected void Page_Load(object sender, EventArgs e)
        {

                OpenSelectUserControl();
        }

        public void SelectUser_UserSelected (object sender, UserSelectEventArgs e)
        {

            this.lblCurrentUser.Text = $"{e.UserFullName} (ID: {e.UserID}; Role: {e.UserRole})";
            this.userID = e.UserID;
            this.userFullName = e.UserFullName;

            ScriptManager.RegisterStartupScript(this, this.GetType(), "useroptions", "OpenUserOptions()", true);
        }

        protected void btnSelectUser_Click(object sender, EventArgs e)
        {
            OpenSelectUserControl();
        }

        protected void btnCreateNewUser_Click(object sender, EventArgs e)
        {
            phAdministration.Controls.Clear();

            AdminCreateUser createUser = (AdminCreateUser)LoadControl("~/Administration/AdminCreateUser.ascx");

            phAdministration.Controls.Add(createUser);
        }

        protected void btnDeleteUser_Click(object sender, EventArgs e)
        {
            // All this does is bring up the modal where the user can choose to delete or not
            ScriptManager.RegisterStartupScript(this, this.GetType(), "idk", "OpenDeleteModal()", true);

        }

        protected void btnEditUser_Click(object sender, EventArgs e)
        {
            phAdministration.Controls.Clear();

            AdminEditUser editUser = (AdminEditUser)LoadControl("~/Administration/AdminEditUser.ascx");

            phAdministration.Controls.Add(editUser);
        }

        protected void btnViewModeration_Click(object sender, EventArgs e)
        {
            if (phAdministration.Controls.Count > 0)
            {
                phAdministration.Controls.Clear();
            }
            
            AdminViewModeration viewModeration = (AdminViewModeration)LoadControl("~/Administration/AdminViewModeration.ascx");
            viewModeration.UserId = this.userID;
            viewModeration.Name = this.userFullName;

            phAdministration.Controls.Add(viewModeration);
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

            // This doesn't actually seem to delete the user, however, however
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
            ScriptManager.RegisterStartupScript(this, this.GetType(), "NoModalDelete", "CloseDeleteModal()", true);
        }
    }
}