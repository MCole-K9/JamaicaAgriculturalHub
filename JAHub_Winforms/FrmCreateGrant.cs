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
        Grantinfo grantinfo = new Grantinfo();
        public FrmCreateGrant()
        {
            InitializeComponent();

        }

        private void FrmCreateGrant_Load(object sender, EventArgs e)
        {
           // pnlNav.Size = new System.Drawing.Size(188, 804);
          //  Size = new Size(1102, 1200);


        }

        public string uploadfile(string filename)
        {
            System.Windows.Forms.OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt | *.txt";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Grantinfo grantinfo = new Grantinfo();
                grantinfo.FilePath = openFileDialog.FileName;
                grantinfo.FileName = openFileDialog.SafeFileName;

                //Utilities.FTPFileUpload(grantinfo.FilePath, grantinfo.FileName);

                //grantinfo.CreateApplication(txtFileInfo.Text);


            }
            return filename;
        }

        private void btnuploadfile_Click(object sender, EventArgs e)
        {

            uploadfile(txtFileinfo.Text);
            txtFileinfo.Text = grantinfo.FileName;
            //CreateApplication(grantinfo);   

        }

        public int CreateApplication(Grantinfo grantinfoFile)
        {
            grantinfoFile = grantinfo;

            string query = $"INSERT INTO [Grant_application] (Filled_Application,Grant) " + $"Values ( '{grantinfoFile.FileName}', {grantinfoFile.GrantOfficerId})";

            Utilities.executeInputQuery(query);
            return 1;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            /* FrmCreateGrant frmCreateGrant = new FrmCreateGrant();
             frmCreateGrant.MdiParent = this.MdiParent;
             frmCreateGrant.Show();*/

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

                    if (txtFileinfo == null)
                {
                    MessageBox.Show("Please enter title", "Missing fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFileinfo.Focus();
                }




                GrantOfficer grantOfficer = new GrantOfficer();
                grantinfo.GrantDescription = rtbdescription.Text;
                grantinfo.Requirement = rtbrequirement.Text;
                grantinfo.ExpiryDate = dtpExpirydate.Value;
                grantinfo.Title = txtcreategranttitle.Text;
                grantinfo.FileName = txtFileinfo.Text;

              
                
                grantinfo.GrantOfficerId = GrantOfficer.FetchGrantOfficerID(Session.UserId);
                grantinfo.CreateGrant(grantinfo);

                rtbdescription.Clear();
                rtbrequirement.Clear();
                dtpExpirydate.ResetText();
                txtcreategranttitle.Clear();
                txtFileinfo.ResetText();    
              
        }

        
    }
}
