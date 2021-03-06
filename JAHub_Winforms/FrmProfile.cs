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
    public partial class FrmProfile : Form
    {
        private Button CurrentButton;
        private Form CurrentChildForm;
        
        // K.S.: Necessary to make opening FrmRadaRegister feasible without weird timing and garbage collection issues
        private RadaRegistrationType usertype;


        public FrmProfile()
        {
            InitializeComponent();
            CurrentChildForm = null;
            //highlight the Dashboard by deffualt
            HighlightButtons(btnDashboard);


        }

        public void OpenChildForm(Form childForm)
        {
            if (CurrentChildForm != null)
            {
                //Opens Only one form
                CurrentChildForm.Close();
            }
            CurrentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            panelHomeContainer.Controls.Add(childForm);
            panelHomeContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void HighlightButtons(object button)
        {
            var btn = (Button)button;
            //Highlight button
            btn.BackColor = btnMyAccount.FlatAppearance.BorderColor;
            btn.ForeColor = Color.White;

            // Reset button to deffualt state
            if (CurrentButton != null && CurrentButton != btn)
            {
                CurrentButton.BackColor = Color.LightSeaGreen;
                CurrentButton.ForeColor = Color.White;
            }
            CurrentButton = btn;

        }


        private void FrmProfile_Load(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDashboard());

            if (Session.UserRole != UserRole.Farmer)
            {
                OpenChildForm(new FrmAccount());
                HighlightButtons(btnMyAccount);
                btnManageProducts.Visible = false;

            }

            // (K.S.) Assumption: Only customers (who wish to register as farmers) and farmers should be able to see 
            // btnRadaStatus (and its associated forms)
            if (Session.UserRole == UserRole.Customer || Session.UserRole == UserRole.Farmer)
            {
                btnRadaStatus.Visible = true;
            }
            else if (Session.UserRole == UserRole.Customer || Session.UserRole == UserRole.GrantOfficer || Session.UserRole == UserRole.Admin)
            {
                btnDashboard.Visible = false;
            }
            else
            {
                btnRadaStatus.Visible = false;
            }
                
                btnViewGrants.Visible = false;
                btnEditGrant.Visible = false;
                btnCreateGrnat.Visible = false;
           


        }

        
        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            
            
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDashboard());
            HighlightButtons(btnDashboard);
        }

        private void btnMyAccount_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmAccount());
            HighlightButtons(btnMyAccount);
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmSecurity());
            HighlightButtons(btnSecurity);
                
        }

        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmManageProducts(this));
            HighlightButtons(btnManageProducts);
        }


        private void btnGrant_Click(object sender, EventArgs e)
        {
            btnCreateGrnat.Show();
            HighlightButtons(btnCreateGrnat);

            btnEditGrant.Show();
            HighlightButtons(btnEditGrant);

            btnViewGrants.Show();
            HighlightButtons(btnViewGrants);
            OpenChildForm(new FrmViewAllMyApplication());
            
        }

        private void btnCreateGrnat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmCreateGrant());
            HighlightButtons(sender);
        }

        private void btnEditGrant_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmCreateGrant());
            HighlightButtons(sender);
        }

        private void btnViewGrants_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmViewAllMyApplication());
            HighlightButtons(sender);
        }

        private void btnRadaStatus_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmRadaStatus(this));
            HighlightButtons(sender);
        }

        public void ClickManageProduct()
        {
            btnManageProducts.PerformClick();
        }

        private void btnViewApplicantion_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmFilledApplication());
            HighlightButtons(sender);
        }
    }
}