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
    public enum AdminUserControls
    {
        SelectUser = 0,
        CreateUser = 1,
        EditUser = 2,
        ViewModeration = 3
    }

    public partial class AdministrationPage : System.Web.UI.Page
    {
        protected AdminUserControls LastControl
        {
            get
            {
                return this.ViewState["LastControl"] == null ? AdminUserControls.SelectUser : (AdminUserControls)this.ViewState["LastControl"];
            }
            set
            {
                this.ViewState["LastControl"] = value;
            }
        }



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
        
        protected void Page_Init(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InsertSelectUser();
                LastControl = AdminUserControls.SelectUser;
            }
            else
            {
                switch (LastControl)
                {
                    // When I call an async postback on stuff inside of the updatepanel, it seems to get a version of LastControl
                    // that isn't set to anything, and thus does the default option (which is InsertSelectUser)
                    // This means i need to somehow add something that works across postbacks in updatepanels, or postbacks generally
                    // not sure yet
                    default:
                        InsertSelectUser();
                        break;
                    case AdminUserControls.CreateUser:
                        InsertCreateUser();
                        break;
                    case AdminUserControls.EditUser:
                        InsertEditUser();
                        break;
                    case AdminUserControls.ViewModeration:
                        InsertViewModeration();
                        break;
                }

            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InsertSelectUser();
                LastControl = AdminUserControls.SelectUser;
            }
            else
            {
                switch (LastControl)
                {
                    // When I call an async postback on stuff inside of the updatepanel, it seems to get a version of LastControl
                    // that isn't set to anything, and thus does the default option (which is InsertSelectUser)
                    // This means i need to somehow add something that works across postbacks in updatepanels, or postbacks generally
                    // not sure yet
                    default:
                        InsertSelectUser();
                        break;
                    case AdminUserControls.CreateUser:
                        InsertCreateUser();
                        break;
                    case AdminUserControls.EditUser:
                        InsertEditUser();
                        break;
                    case AdminUserControls.ViewModeration:
                        InsertViewModeration();
                        break;
                }

            }
        }

        public void SelectUser_UserSelected (object sender, UserSelectEventArgs e)
        {
            LastControl = AdminUserControls.SelectUser;

            this.lblCurrentUser.Text = $"{e.UserFullName} (ID: {e.UserID}; Role: {e.UserRole})";
            this.userID = e.UserID;
            this.userFullName = e.UserFullName;

            ScriptManager.RegisterStartupScript(this, this.GetType(), "useroptions", "OpenUserOptions()", true);
        }

        protected void btnSelectUser_Click(object sender, EventArgs e)
        {
            LastControl = AdminUserControls.SelectUser;
            ViewState.SetItemDirty("LastControl", true);
            InsertSelectUser();
        }

        protected void btnCreateNewUser_Click(object sender, EventArgs e)
        {
            LastControl = AdminUserControls.CreateUser;
            ViewState.SetItemDirty("LastControl", true);
            InsertCreateUser();
        }

        protected void btnDeleteUser_Click(object sender, EventArgs e)
        {
            // All this does is bring up the modal where the user can choose to delete or not
            ScriptManager.RegisterStartupScript(this, this.GetType(), "idk", "OpenDeleteModal()", true);

        }

        protected void btnEditUser_Click(object sender, EventArgs e)
        {
            LastControl = AdminUserControls.EditUser;
            ViewState.SetItemDirty("LastControl", true);
            InsertEditUser();            
        }

        protected void btnViewModeration_Click(object sender, EventArgs e)
        {
            LastControl = AdminUserControls.ViewModeration;
            ViewState.SetItemDirty("LastControl", true);
            InsertViewModeration();
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

            // This ensures that on the next pageback, it will bring up the SelectUser UC
            LastControl = AdminUserControls.SelectUser;
            ViewState.SetItemDirty("LastControl", true);
            lblCurrentUser.Text = "Current User: none selected";

        }

        protected void btnDeleteNo_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "NoModalDelete", "CloseDeleteModal()", true);
        }

        protected void InsertSelectUser()
        {
            if (phAdministration.Controls.Count > 0)
            {
                phAdministration.Controls.Clear();
            }

            AdminSelectUser selectUser = (AdminSelectUser)LoadControl("~/Administration/AdminSelectUser.ascx");
            selectUser.UserSelected += new EventHandler<UserSelectEventArgs>(SelectUser_UserSelected);

            phAdministration.Controls.Add(selectUser);
        }

        protected void InsertCreateUser()
        {
            if (phAdministration.Controls.Count > 0)
            {
                phAdministration.Controls.Clear();
            }
            
            AdminCreateUser createUser = (AdminCreateUser)LoadControl("~/Administration/AdminCreateUser.ascx");

            phAdministration.Controls.Add(createUser);
        }

        protected void InsertEditUser()
        {
            if (phAdministration.Controls.Count > 0)
            {
                phAdministration.Controls.Clear();
            }

            AdminEditUser editUser = (AdminEditUser)LoadControl("~/Administration/AdminEditUser.ascx");

            phAdministration.Controls.Add(editUser);
        }

        protected void InsertViewModeration()
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

    }
}