﻿using System;
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
            pnlNav.Size = new System.Drawing.Size(188, 804);
            Size = new Size(1102, 1200);


        }

        private void btnuploadfile_Click(object sender, EventArgs e)
        {

           // grantinfo.uploadfile(Int16.Parse (grantinfo.Application_Form);

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


                GrantOfficer grantOfficer = new GrantOfficer();
                grantinfo.GrantDescription = rtbdescription.Text;
                grantinfo.Requirement = rtbrequirement.Text;
                grantinfo.ExpiryDate = dtpExpirydate.Value;
                grantinfo.Title = txtcreategranttitle.Text;
                grantinfo.Application_Form = int.Parse(txtapplicationnumber.Text);
                grantinfo.GrantOfficerId = GrantOfficer.FetchGrantOfficerID(Session.UserId);
                
                grantinfo.GrantOfficerId = GrantOfficer.FetchGrantOfficerID(Session.UserId);
                grantOfficer.CreateGrant(grantinfo);

                rtbdescription.Clear();
                rtbrequirement.Clear();
                dtpExpirydate.ResetText();
                txtcreategranttitle.Clear();
                txtapplicationnumber.ResetText();

                

            

          



        }
    }
}
