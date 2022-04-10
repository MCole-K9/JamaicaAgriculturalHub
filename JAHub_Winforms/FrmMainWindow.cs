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
            bool isFormOpen = false;
            
            foreach(Form form in this.MdiChildren)
            {
                if (form is FrmAdminContainer)
                {
                    isFormOpen = true;
                    form.BringToFront();
                }
            }
            
            if (!isFormOpen)
            {
                FrmAdminContainer frmAdmin = new FrmAdminContainer();
                frmAdmin.MdiParent = this;
                frmAdmin.Show();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mnsMainForm.Hide();
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
            lblLoggedInAs.Text = "Logged in as: " + Session.Name + "( ID: " + Session.UserId + ")";
            lblLoggedInRole.Text = "Role: " + Session.UserRole;

            if (Session.UserRole == UserRole.Admin)
            {
                // Admins see: Pretty much everything (will revise)
                miAdmin.Visible = true;
                miBlog.Visible = true;
                miHome.Visible = true;
                miShop.Visible = true;
                miUserProfile.Visible = true;
                grantsToolStripMenuItem.Visible = true;
                
                mnsMainForm.Show();
            }
            else if (Session.UserRole == UserRole.Customer)
            {
                // Customers see: Home, Shop, User Profile
                miAdmin.Visible = false;
                miBlog.Visible = false;
                miHome.Visible = true;
                miShop.Visible = true;
                miUserProfile.Visible = true;
                grantsToolStripMenuItem.Visible = false;

                mnsMainForm.Show();
            }
            else if(Session.UserRole == UserRole.Farmer)
            {
                // Farmers see: Blog, Home, Shop, User Profile, Grants
                miAdmin.Visible = false;
                miBlog.Visible = true;
                miHome.Visible = true;
                miShop.Visible = true;
                miUserProfile.Visible = true;
                grantsToolStripMenuItem.Visible = true;

                mnsMainForm.Show();
            }
            else if (Session.UserRole == UserRole.GrantOfficer)
            {
                // Grant Officers see: Grants, Home

                miAdmin.Visible = false;
                miBlog.Visible = false;
                miHome.Visible= true;
                miShop.Visible = false;
                miUserProfile.Visible = false;
                grantsToolStripMenuItem.Visible = true;

                mnsMainForm.Show();
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void FrmMainWindow_SizeChanged(object sender, EventArgs e)
        {
            foreach (Form form in MdiChildren)
            {
                if (form is FrmLogin)
                {
                    form.Left = (this.ClientRectangle.Width - form.Width) / 2;
                    form.Top = (this.ClientRectangle.Height - form.Height) / 2 - 28;
                }
            }
        }

        private void grantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.IsFormOpen("FrmGeneralGrantInfo"))
            {

                FrmGeneralGrantInfo frmGeneralGrantInfo = new FrmGeneralGrantInfo();
                frmGeneralGrantInfo.MdiParent = this;
                frmGeneralGrantInfo.Show();
            }
            else
            {
                MessageBox.Show("An Instance is Already Running");
            }
        }

        private void FrmMainWindow_Load(object sender, EventArgs e)
        {
            // Hiding the Menustrip on load, not especially necessary tbh
            mnsMainForm.Hide();
        }


        private void FrmMainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Utilities.DeleteImages();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex.GetType().ToString()} Message: {ex.Message}");
            }
            
        }

        public void GenerateRadaForm (FrmProfile _formContainer, RadaRegistrationType farmerRegistrationPhase)
        {
            FrmRadaRegister rada = new FrmRadaRegister(_formContainer, farmerRegistrationPhase);
            rada.MdiParent = this;
            rada.Show();
        }
    }
}
