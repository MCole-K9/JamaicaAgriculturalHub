using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAHub_Winforms
{
    public partial class FrmProfile : Form
    {
        private Button CurrentButton;
        private Form CurrentChildForm;


        public FrmProfile()
        {
            InitializeComponent();
            CurrentChildForm = null;
            //highlight the Dashboard by deffualt
            HighlightButtons(btnDashboard);


        }

        private void OpenChildForm(Form childForm)
        {
            if (CurrentChildForm != null)
            {
                //Opens Only one form
                CurrentChildForm.Close();
            }
            CurrentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            panelMenu.Controls.Add(childForm);
            panelMenu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void HighlightButtons(object button)
        {
            var btn = (Button)button;
            //Highlight button
            btn.BackColor = btnProfileHome.FlatAppearance.BorderColor;
            btn.ForeColor = Color.White;

            // Reset button to deffualt state
            if(CurrentButton != null && CurrentButton != btn)
            {
                CurrentButton.BackColor = Color.LightSeaGreen;
                CurrentButton.ForeColor = Color.White;
            }
            CurrentButton = btn;

        }


        private void FrmProfile_Load(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDashboard());
            //FrmDashboard frmDashboard = new FrmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //this.panelHomeContainer.Controls.Add(frmDashboard);
            //frmDashboard.Show();

        }

            private void btnProfileHome_Click(object sender, EventArgs e)
        {
                FrmProfileHome frmHome = new FrmProfileHome() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.panelHomeContainer.Controls.Add(frmHome);
                frmHome.Show();
                HighlightButtons(sender); //or pass the button name as a arg instead of sender
        }

        
        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            
            
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelHomeContainer.Controls.Add(frmDashboard);
            frmDashboard.Show();
            HighlightButtons(btnDashboard);
        }

        private void btnMyAccount_Click(object sender, EventArgs e)
        {
            FrmAccount frmAccount = new FrmAccount() { Dock = DockStyle.Fill,TopLevel = false, TopMost = true};
            this.panelHomeContainer.Controls.Add(frmAccount);
            frmAccount.Show();
            HighlightButtons(btnMyAccount);
        }
    }
}
