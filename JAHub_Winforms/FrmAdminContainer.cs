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
using System.Data.SqlClient;

namespace JAHub_Winforms
{
    public partial class FrmAdminContainer : Form
    {
        User _user;
        int _userId;
        public FrmAdminContainer()
        {
            InitializeComponent();
            _user = new User();
        }

        private void btnSelectUser_Click(object sender, EventArgs e)
        {
            if (pnlFormHolder.Controls.Count > 0)
            {
                Form form = (Form)pnlFormHolder.Controls[0];

                form.Close();
                pnlFormHolder.Controls.Clear();
            }

            pnlFormHolder.Controls.Add(new FrmAdminSelectUser(this));
            pnlFormHolder.Controls[0].Show();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (pnlFormHolder.Controls.Count > 0)
            {
                Form form = (Form)pnlFormHolder.Controls[0];

                form.Close();
                pnlFormHolder.Controls.Clear();
            }

            pnlFormHolder.Controls.Add(new FrmAdminEditUser(_userId));
            pnlFormHolder.Controls[0].Show();
        }

        private void btnViewModeration_Click(object sender, EventArgs e)
        {
            if (pnlFormHolder.Controls.Count > 0)
            {
                Form form = (Form)pnlFormHolder.Controls[0];

                form.Close();
                pnlFormHolder.Controls.Clear();
            }

            pnlFormHolder.Controls.Add(new FrmAdminViewModeration(_userId, lblNameValue.Text, lblRoleValue.Text));
            pnlFormHolder.Controls[0].Show();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            String message = "Are you sure you want to delete the account of" + 
                lblNameValue.Text + " (ID: " + _userId.ToString() + ", Role: " +
                lblRoleValue.Text + ")";
            const String caption = "Delete Account";
            
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
                {
                    connection.Open();

                    String command = $"DELETE FROM [User] WHERE ID={_userId};";

                    SqlCommand deleteRecord = new SqlCommand(command, connection);

                    deleteRecord.ExecuteNonQuery();

                    connection.Close();
                }
                
                HideUserOptions();

                if (pnlFormHolder.Controls.Count > 0)
                {
                    Form form = (Form)pnlFormHolder.Controls[0];

                    form.Close();
                    pnlFormHolder.Controls.Clear();
                }

                pnlFormHolder.Controls.Add(new FrmAdminSelectUser(this));
                pnlFormHolder.Controls[0].Show();

                // these just empty the "Current User" section
                lblUserIdValue.Text = "";
                lblNameValue.Text = "";
                lblRoleValue.Text = "";
            }
        }

        private void btnCreateNewUser_Click(object sender, EventArgs e)
        {
            if (pnlFormHolder.Controls.Count > 0)
            {
                Form form = (Form)pnlFormHolder.Controls[0];

                form.Close();

                pnlFormHolder.Controls.Clear();
            }

            pnlFormHolder.Controls.Add(new FrmAdminCreateNewUser(this));
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
            this._userId = userId;
            lblUserIdValue.Text = userId.ToString();
            lblNameValue.Text = userName;
            lblRoleValue.Text = userRole;

            ShowUserOptions();
        }
    }
}
