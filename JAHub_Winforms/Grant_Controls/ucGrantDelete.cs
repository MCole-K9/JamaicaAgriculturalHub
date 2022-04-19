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

namespace JAHub_Winforms.Grant_Controls
{
    public partial class ucGrantDelete : UserControl
    {
        public ucGrantDelete()
        {
            InitializeComponent();
        }

        public ucGrantDelete(Grantinfo grantinfo )
        {
            InitializeComponent();
            lblGrantAgency.Text = grantinfo.Title;
            rtbGrantDescription.Text = grantinfo.GrantDescription;

        }

        private void lblGrantAgency_Click(object sender, EventArgs e)
        {

        }

        private void rtbGrantDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnViewGrant_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            {
                Grantinfo grantinfo = new Grantinfo();
                grantinfo.ID = GrantOfficer.FetchGrantOfficerID(Session.UserId);
                

            }
        }

    }
}
