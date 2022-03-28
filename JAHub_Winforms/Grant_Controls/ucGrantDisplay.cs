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
        public ucGrantDisplay(Grantinfo g)
        {
            this.grantinfo = g;
            InitializeComponent();
            lblGrantAgency.Text = grantinfo.Title;
            rtbGrantDescription.Text = grantinfo.GrantDescription;
            //txtExpirationDate.Text = grantinfo.ExpiryDate;
        }

        private void btnViewGrant_Click(object sender, EventArgs e)
        {
            FrmGrantDetails frmGrantDetails = new FrmGrantDetails(grantinfo);
            frmGrantDetails.Show();
        }
    }
}
