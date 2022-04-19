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
    public partial class FrmEditGrantInfo : Form
    {
        public FrmEditGrantInfo()
        {
            InitializeComponent();
        }

        private void FrmEditGrantInfo_Load(object sender, EventArgs e)
        {

        }

        private void btngrantcreate_Click(object sender, EventArgs e)
        {
            FrmCreateGrant frmCreateGrant = new FrmCreateGrant();
            frmCreateGrant.ShowDialog();    
        }

        private void btngrantHome_Click(object sender, EventArgs e)
        {
            FrmGeneralGrantInfo frmGeneralGrantinfo = new FrmGeneralGrantInfo();    
            frmGeneralGrantinfo.ShowDialog();
        }

        private void btnViewall_Click(object sender, EventArgs e)
        {
            FrmViewAllMyApplication frmViewAllMyApplication = new FrmViewAllMyApplication();
            frmViewAllMyApplication.ShowDialog();   
        }

        private void btnDeleteGrant_Click(object sender, EventArgs e)
        {

        }
    }
}
