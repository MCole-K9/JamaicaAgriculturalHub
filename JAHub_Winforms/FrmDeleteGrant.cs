using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using JAHubLib;

namespace JAHub_Winforms
{
    public partial class FrmDeleteGrant : Form
    {
        public FrmDeleteGrant()
        {
            InitializeComponent();
        }


      
        private void btnDeletetitleSubmit_Click(object sender, EventArgs e)
        {
            Grantinfo grantinfo = new Grantinfo();
            grantinfo.ID = Int32.Parse  (txtDeletetitleinfo.Text);
            grantinfo.DeleteGrant(grantinfo.ID);
          
        }
            
    }
}
