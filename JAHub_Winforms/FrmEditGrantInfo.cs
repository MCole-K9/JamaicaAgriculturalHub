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
    public partial class FrmEditGrantInfo : Form
    {
        Grantinfo grantinfo =  new Grantinfo(); 
        public FrmEditGrantInfo()
        {
            InitializeComponent();
        }

        public FrmEditGrantInfo(Grantinfo g)
        {
            grantinfo = g;
            InitializeComponent();
           ;  
            
           
        }

        private void FrmEditGrantInfo_Load(object sender, EventArgs e)
        {
        
        }

        private void btngrantcreate_Click(object sender, EventArgs e)
        {
            if (!Utils.IsFormOpen(" FrmCreateGrant"))
            {

                FrmCreateGrant frmCreateGrant = new FrmCreateGrant();
                frmCreateGrant.MdiParent = this.MdiParent;
                frmCreateGrant.Show();
            }
            else
            {
                foreach (var form in this.MdiParent.MdiChildren)
                {
                    if (form.Text == "FrmCreateGrant")
                    {
                        form.BringToFront();
                    }
                }
            }  
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

       
        private void btnUpdateGrant_Click(object sender, EventArgs e)
        {
            FrmEditGrantInfo frmEditGrantInfo = new FrmEditGrantInfo();
            frmEditGrantInfo.Show();
        }

        private void btnupdateform_Click(object sender, EventArgs e)
        {
            
        }

       

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (rtbdescription == null)
            {
                MessageBox.Show("Please enter description", "Missing fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rtbdescription.Focus();
            }

            if (rtbrequirement == null)
            {
                MessageBox.Show("Please enter requirements", "Missing fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rtbrequirement.Focus();

            }


            if (txtcreategranttitle == null)
            {
                MessageBox.Show("Please enter title", "Missing fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtcreategranttitle.Focus();
            }

            if (txtFileInfo== null)
            {
                MessageBox.Show("Please enter title", "Missing fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFileInfo.Focus();
            }
            grantinfo.Requirement = rtbrequirement.Text;
            grantinfo.GrantDescription = rtbdescription.Text;
            grantinfo.Title = txtcreategranttitle.Text;
            grantinfo.Application_Form = txtFileInfo.Text;
            txtFileInfo.ResetText();
            //grantinfo.UpdateGrant(grantinfo);
        }
    }
}
