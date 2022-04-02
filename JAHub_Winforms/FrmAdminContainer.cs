using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JAHubLib;

namespace JAHub_Winforms
{
    public partial class FrmAdminContainer : Form
    {
        User _user;
        public FrmAdminContainer()
        {
            InitializeComponent();
            _user = new User();
        }

        private void btnSelectUser_Click(object sender, EventArgs e)
        {
            if (pnlFormHolder.Controls.Count > 0)
            {
                pnlFormHolder.Controls.Clear();
            }

            pnlFormHolder.Controls.Add(new FrmAdminSelectUser(this));
            pnlFormHolder.Controls[0].Show();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (pnlFormHolder.Controls.Count > 0)
            {
                pnlFormHolder.Controls.Clear();
            }

            pnlFormHolder.Controls.Add(new FrmAdminEditUser());
            pnlFormHolder.Controls[0].Show();
        }

        private void btnViewModeration_Click(object sender, EventArgs e)
        {
            if (pnlFormHolder.Controls.Count > 0)
            {
                pnlFormHolder.Controls.Clear();
            }

            pnlFormHolder.Controls.Add(new FrmAdminViewModeration());
            pnlFormHolder.Controls[0].Show();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            String message = "Are you sure you want to delete the account of" + 
                _user.FirstName + _user.LastName;
            const String caption = "Delete Account";
            
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // query to delete the corresponding record
                // return the user to Select User
                
                HideUserOptions();

                if (pnlFormHolder.Controls.Count > 0)
                {
                    pnlFormHolder.Controls.Clear();
                }

                pnlFormHolder.Controls.Add(new FrmAdminSelectUser(this));
                pnlFormHolder.Controls[0].Show();

                // empty the Current User table
            }
        }

        private void btnCreateNewUser_Click(object sender, EventArgs e)
        {
            if (pnlFormHolder.Controls.Count > 0)
            {
                pnlFormHolder.Controls.Clear();
            }

            pnlFormHolder.Controls.Add(new FrmAdminCreateNewUser());
            pnlFormHolder.Controls[0].Show();
        }

        private void pnlFormHolder_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control control in pnlFormHolder.Controls)
            {
                control.Width = pnlFormHolder.Width;
                control.Height = pnlFormHolder.Height;
            }
        }

        // Literally: hides the View Moderation Log, Edit User, and Delete User options
        private void HideUserOptions()
        {
            btnDeleteUser.Visible = false;
            btnViewModeration.Visible = false;
            btnEditUser.Visible = false;
        }

        // And the inverse, to show the user
        private void ShowUserOptions()
        {
            btnDeleteUser.Show();
            btnViewModeration.Show();
            btnEditUser.Show();
        }

        public void SetCurrentUser(int userId, String userName, String userRole)
        {
            lblUserIdValue.Text = userId.ToString();
            lblNameValue.Text = userName;
            lblRoleValue.Text = userRole;
            
            // idr really think this is necessary, yet
            _user = new User();

            ShowUserOptions();
        }
    }
}
