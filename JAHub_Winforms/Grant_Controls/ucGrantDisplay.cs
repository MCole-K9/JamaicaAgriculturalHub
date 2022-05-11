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
using System.Windows.Forms;

namespace JAHub_Winforms.Grant_Controls
{
    public partial class ucGrantDisplay : UserControl
    {
        Grantinfo grantinfo;
        private object MdiParent;

        public ucGrantDisplay()
        {
           
            InitializeComponent();
        }
        public ucGrantDisplay(Grantinfo g)
        {
            grantinfo = g;
            InitializeComponent();
            txtUcAgencyName.Text = grantinfo.Title;
            rtbGrantDescription.Text = grantinfo.GrantDescription;
           
           
        }

       
        private void btnViewGrant_Click(object sender, EventArgs e)
        {
            if (!Utils.IsFormOpen(" FrmGrantDetails"))
            {

                FrmGrantDetails frmGrantDetails = new FrmGrantDetails(grantinfo);
                
                //frmGrantDetails.MdiParent = (Form)MdiParent;
                frmGrantDetails.Show();
                //var form = frmGrantDetails;
                //form.BringToFront();

            }

        }

       
    }
}
