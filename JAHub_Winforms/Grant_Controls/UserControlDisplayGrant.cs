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
using System.Data.SqlClient;

namespace JAHub_Winforms.Grant_Controls
{
    public partial class UserControlDisplayGrant : UserControl
    {
        Grantinfo grantinfo = new Grantinfo();
        public UserControlDisplayGrant()
        {
            InitializeComponent();
        }

        public UserControlDisplayGrant(Grantinfo g)
        {
            grantinfo = g;
            InitializeComponent();
            rtbgrantdescription.Text = grantinfo.GrantDescription;
            txtviewgranttitle.Text = grantinfo.Title;
            

        }

       
        private void btnviewmore_Click(object sender, EventArgs e)
        {
            Grantinfo grantinfo = new Grantinfo();
            FrmGrantDetails frmGrantDetails = new FrmGrantDetails(grantinfo);
            frmGrantDetails.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if(CbSelected.Checked==true)
            {
                grantinfo.DeleteGrant(grantinfo.ID);
                CbSelected.Checked=false; 
            }
        }

        private void btnUpdategrant_Click(object sender, EventArgs e)
        {
            FrmEditGrantInfo frmEditGrantInfo = new FrmEditGrantInfo();
            frmEditGrantInfo.Show();    

            if (CbSelected.Checked == true)
            {
                FrmEditGrantInfo frmEditGrantInfo1 = new FrmEditGrantInfo(grantinfo);
                frmEditGrantInfo.Show();
               // grantinfo.UpdateGrant(grantinfo);
            }
        }

        private void rtbgrantdescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
