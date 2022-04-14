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


       
        private void btnCreateGrant_Click(object sender, EventArgs e)
        {

            
         


            
            GrantOfficer grantOfficer = new GrantOfficer();
            Grantinfo grantinfo = new Grantinfo();
            grantinfo.GrantDescription = rtbdescription.Text;
            grantinfo.Requirement = rtbrequirement.Text;
            grantinfo.ExpiryDate = dtpExpirydate.Value;
            // grantinfo.GrantOfficerId = ;
            grantinfo.GrantOfficerId =;

           
           
           grantOfficer.CreateGrant(grantinfo);


        }

       




        private void FrmCreateGrant_Load(object sender, EventArgs e)
        {
          /* Grantinfo grantinfo = new Grantinfo() ;  
             CreateGrant(grantinfo);*/
        }
    }
        }
