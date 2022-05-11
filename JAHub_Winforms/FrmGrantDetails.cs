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
        GrantApplication grantApplication = new GrantApplication();
        Grantinfo grantinfo =new Grantinfo();
        public FrmGrantDetails( )
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
            txtapplicationnumber.Text =  (grantinfo.Application_Form).ToString();
           
        }


        private void FrmGrantDetails_Load (object sender, EventArgs e)
        {
            Size = new Size(1102, 1200);

            lblexpirydategrantdetails.Text = grantinfo.ExpiryDate.ToString();
            txtcreategranttitle.Text = grantinfo.Title;
            rtbdescription.Text = grantinfo.GrantDescription;
            rtbrequirement.Text = grantinfo.Requirement;
            txtapplicationnumber.Text =  (grantinfo.Application_Form.ToString());
            
            

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

                grantinfo.CreateApplication(txtFileInfo.Text);

               
            }
            return filename;
        }

        private void btnuploadfile_Click(object sender, EventArgs e)
        {
             
            grantApplication.GrantApplicationId = grantinfo.Application_Form;
            //grantApplication.FilledApplication = uploadfile(grantApplication.FilledApplication);
            txtFileInfo.Text = grantApplication.FilledApplication.ToString();

            uploadfile(txtFileInfo.Text);
            txtFileInfo.Text = grantinfo.FileName;

        }

        private void btnHome_Click (object sender, EventArgs e)
        {
            FrmGeneralGrantInfo frmGeneralGrantInfo = new FrmGeneralGrantInfo();
            frmGeneralGrantInfo.ShowDialog();   
        }

        private void btnSubmit(object sender, EventArgs e)
        {
            /*GrantApplication gr = new GrantApplication();*/
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmFilledApplication frmFilledApplication = new FrmFilledApplication(grantinfo);
            txtFileInfo.ResetText();    
        }
    }
}



