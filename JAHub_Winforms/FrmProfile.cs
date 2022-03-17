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
        public FrmProfile()
        {
            InitializeComponent();
            
        }

        private void FrmProfile_Load(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelHomeContainer.Controls.Add(frmDashboard);
            frmDashboard.Show();
        }

        private void btnProfileHome_Click(object sender, EventArgs e)
        {
            
             btnProfileHome.BackColor = Color.Aqua; 
            
            
                FrmProfileHome frmHome = new FrmProfileHome() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.panelHomeContainer.Controls.Add(frmHome);
                frmHome.Show();
            
        }

        
        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            
            
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelHomeContainer.Controls.Add(frmDashboard);
            frmDashboard.Show();
        }

        private void btnMyAccount_Click(object sender, EventArgs e)
        {
            FrmAccount frmAccount = new FrmAccount() { Dock = DockStyle.Fill,TopLevel = false, TopMost = true};
            this.panelHomeContainer.Controls.Add(frmAccount);
            frmAccount.Show();
        }
    }
}
