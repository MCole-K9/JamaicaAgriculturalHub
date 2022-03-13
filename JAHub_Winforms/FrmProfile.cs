using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAH_Desktop
{
    public partial class FrmProfile : Form
    {
        public FrmProfile()
        {
            InitializeComponent();
            
        }

        private void btnProfileHome_Click(object sender, EventArgs e)
        {
             

            FrmProfileHome home = new FrmProfileHome() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true}; 
            this.panelHomeContainer.Controls.Add(home);
            home.Show();
        }

        private void FrmProfile_Load(object sender, EventArgs e)
        {
            FrmProfileHome home = new FrmProfileHome() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelHomeContainer.Controls.Add(home);
            home.Show();
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            
            
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
                frmDashboard.Show();
        }
    }
}
