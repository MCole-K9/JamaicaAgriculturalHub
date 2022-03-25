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
    public partial class FrmMainWindow : Form
    {
        public FrmMainWindow()
        {
            InitializeComponent();

            CreateLoginForm();
        }

        private void shopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.IsFormOpen("FrmShop"))
            {

                FrmShop frmShop = new FrmShop();
                frmShop.MdiParent = this;
                frmShop.Show();
            }
            else
            {
                MessageBox.Show("An Instance is Already Running");
            }


        }

        private void blogToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!Utils.IsFormOpen("FrmBlog"))
            {

                FrmBlog frmBlog = new FrmBlog();
                frmBlog.MdiParent = this;
                frmBlog.Show();
            }
            else
            {
                MessageBox.Show("An Instance is Already Running");
            }
        }

        private void userPortalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.IsFormOpen("Profile"))
            {
                FrmProfile frmProfile = new FrmProfile();
                frmProfile.MdiParent = this;
                frmProfile.Show();
            }
            else
            {
                MessageBox.Show("An Instance is Already Running");
            }

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.IsFormOpen("Admininstration")){
                FrmAdminContainer frmAdmin = new FrmAdminContainer();
                frmAdmin.MdiParent = this;
                frmAdmin.Show();
            }
            else
            {
                MessageBox.Show("An Instance is Already Running");
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        private void LogOut()
        {
            mnsMainForm.Enabled = false;
            
            if (this.MdiChildren != null)
            {
                foreach (var child in this.MdiChildren)
                {
                    child.Close();
                }
            }

            lblLoggedInAs.Text = "Not Logged In";
            lblLoggedInRole.Text = "";

            Session.LogOut();
            CreateLoginForm();
        }

        private void CreateLoginForm()
        {
            FrmLogin login = new FrmLogin();
            login.MdiParent = this;
            login.Show();
        }

        public void UnlockControls()
        {
            mnsMainForm.Enabled = true;
            lblLoggedInAs.Text = "Logged in as: " + Session.UserId;
            lblLoggedInRole.Text = "Role: " + Session.UserRole;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
