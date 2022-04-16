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
            Size = new Size(1102, 1200);
        }

        private void btnCreateGrant_Click(object sender, EventArgs e)
        {
            Grantinfo grantinfo = new Grantinfo();
            grantinfo.GrantDescription= rtbdescription.Text ;
            grantinfo.Requirement= rtbrequirement.Text ;
            grantinfo.ExpiryDate = dtpExpirydate.Value ;
            
         //   grantinfo.FileName = pbfile.

            GrantOfficer grantOfficer = new GrantOfficer();
            grantOfficer.CreateGrant(grantinfo);




        }


     
       
            
            GrantOfficer grantOfficer = new GrantOfficer();
            Grantinfo grantinfo = new Grantinfo();
            grantinfo.GrantDescription = rtbdescription.Text;
            grantinfo.Requirement = rtbrequirement.Text;
            grantinfo.ExpiryDate = dtpExpirydate.Value;
            grantinfo.Title = txtcreategranttitle.Text;
            grantinfo.ApplicationId = txtapplicationnumber.Text;
            grantinfo.GrantOfficerId = GrantOfficer.FetchGrantOfficerID(Session.UserId);           
            grantOfficer.CreateGrant(grantinfo);

            rtbdescription.Clear();
            rtbrequirement.Clear(); 
            dtpExpirydate.ResetText();
            txtcreategranttitle.ResetText();
            txtapplicationnumber.ResetText();








            }
        }
      
    }
 }
