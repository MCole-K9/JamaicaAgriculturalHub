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

namespace JAHub_Winforms
{
    public partial class FrmCreateGrant : Form
    {
        Grantinfo grantinfo;
        public FrmCreateGrant()
        {
            InitializeComponent();

        }

        private void FrmCreateGrant_Load(object sender, EventArgs e)
        {
            pnlNav.Size = new System.Drawing.Size(188, 804);
            Size = new Size(1102, 1200);
            
        }

        private void btnuploadfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt | *.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Grantinfo grantinfo = new Grantinfo();
                grantinfo.FilePath = openFileDialog.FileName;
                grantinfo.FileName = openFileDialog.SafeFileName;

                Utilities.FTPFileUpload(grantinfo.FilePath, grantinfo.FileName);
                //MessageBox.Show(grantinfo.FileName + grantinfo.FilePath);
            }

        }

        private void btnCreateGrant_Click(object sender, EventArgs e)
        {
            if (rtbdescription == null) 
            {
                rtbdescription.Focus();
            }

            if(rtbrequirement == null)
            {
                rtbrequirement.Focus();
            }   

            if (txtapplicationnumber == null)
            {
                txtapplicationnumber.Focus();   
            }

            if (txtcreategranttitle == null)
            {
                txtcreategranttitle.Focus();
            }


            GrantOfficer grantOfficer = new GrantOfficer();
            Grantinfo grantinfo = new Grantinfo();
            grantinfo.GrantDescription = rtbdescription.Text;
            grantinfo.Requirement = rtbrequirement.Text;
            grantinfo.ExpiryDate = dtpExpirydate.Value;
            grantinfo.Title = txtcreategranttitle.Text;
            grantinfo.ApplicationId = txtapplicationnumber.Text;
            grantinfo.GrantOfficerId = GrantOfficer.FetchGrantOfficerID(Session.UserId);
            //grantOfficer.CreateGrant(grantinfo);

            rtbdescription.Clear();
            rtbrequirement.Clear();
            dtpExpirydate.ResetText();
            txtcreategranttitle.Clear();
            txtapplicationnumber.ResetText();

           
            grantinfo.GrantOfficerId = GrantOfficer.FetchGrantOfficerID(Session.UserId);
            grantOfficer.CreateGrant(grantinfo);

        }

       

       
    }
}
