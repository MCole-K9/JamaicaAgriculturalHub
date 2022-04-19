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
        public UserControlDisplayGrant()
        {
            InitializeComponent();
        }

        public UserControlDisplayGrant(Grantinfo grantinfo)
        {
            
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
            Grantinfo grantinfo = new Grantinfo();
           int  x = grantinfo.ID;
            string y = x.ToString();

            if(CbSelected.Checked==true)
            {
                grantinfo.DeleteGrant();

                MessageBox.Show(y);
            }
        }

        
    }
}
