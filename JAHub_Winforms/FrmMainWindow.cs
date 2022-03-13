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
    public partial class FrmMainWindow : Form
    {
        public FrmMainWindow()
        {
            InitializeComponent();
        }
       
        private void shopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.IsFormOpen("FrmShop")){

                FrmShop frmShop = new FrmShop();
                frmShop.MdiParent = this;
                frmShop.Show();
            }
            else
            {
                MessageBox.Show("An Instance is Already Running");
            }

 
        }

        private void blogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (!Utils.IsFormOpen("FrmBlog"))
            {

                FrmBlog frmBlog = new FrmBlog();
                frmBlog.MdiParent = this;
                frmBlog.Show();
            }
            else
            {
                MessageBox.Show("An Instance is Already Running");
            }
        }

        private void userProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.IsFormOpen("Profile")) 
            {
                FrmProfile frmProfile = new FrmProfile();
                frmProfile.MdiParent = this;
                frmProfile.Show();
            }
            
        }
    }
}
