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
using System.IO;

namespace JAHub_Winforms
{
    public partial class FrmGrantDetails : Form
    {
        Grantinfo grantinfo =new Grantinfo();
        public FrmGrantDetails()
        {
            InitializeComponent();
        }

        public FrmGrantDetails(Grantinfo g)
        {
           grantinfo = g;
            InitializeComponent();
            lblexpirydategrantdetails.Text = grantinfo.ExpiryDate.ToString();
            txtcreategranttitle.Text = grantinfo.Title;
            rtbdescription.Text = grantinfo.GrantDescription;
            rtbrequirement.Text = grantinfo.Requirement;
            txtapplicationnumber.Text = grantinfo.Application_Form;
           
        }


        private void FrmGrantDetails_Load (object sender, EventArgs e)
        {
            Size = new Size(1102, 1200);

            lblexpirydategrantdetails.Text = grantinfo.ExpiryDate.ToString();
            txtcreategranttitle.Text = grantinfo.Title;
            rtbdescription.Text = grantinfo.GrantDescription;
            rtbrequirement.Text = grantinfo.Requirement;
            txtapplicationnumber.Text = grantinfo.Application_Form;

        }

        private void btnuploadfile_Click(object sender, EventArgs e)
        {
            grantinfo.uploadfile(grantinfo.Application_Form);
        }

        private void btnHome_Click (object sender, EventArgs e)
        {
            FrmGeneralGrantInfo frmGeneralGrantInfo = new FrmGeneralGrantInfo();
            frmGeneralGrantInfo.ShowDialog();   
        }
    }
}



