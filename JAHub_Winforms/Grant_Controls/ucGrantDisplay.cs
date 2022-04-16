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

namespace JAHub_Winforms.Grant_Controls
{
    public partial class ucGrantDisplay : UserControl
    {
        Grantinfo grantinfo = new Grantinfo();
        public ucGrantDisplay()
        {
           
            InitializeComponent();
        }
        public ucGrantDisplay(Grantinfo grantinfo)
        {
            
            InitializeComponent();
            txtUcAgencyName.Text = grantinfo.Title;
            rtbGrantDescription.Text = grantinfo.GrantDescription;
           
        }

        private void btnViewGrant_Click(object sender, EventArgs e)
        {
            Grantinfo grantinfo = new Grantinfo(); 
            FrmGrantDetails frmGrantDetails = new FrmGrantDetails(grantinfo);
            frmGrantDetails.Show();
        }

       
    }
}
