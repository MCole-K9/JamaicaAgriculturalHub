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
    public partial class FrmGeneralGrantInfo : Form
    {

        public FrmGeneralGrantInfo()
        {
            InitializeComponent();
        }


        public void DisplayGrantinfo()
        {
            using (SqlConnection conn = new SqlConnection(Utilities.getConnectionString()))
            {
                conn.Open();
                string query = "Select * from [Grant]";
                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader sqlRead = cmd.ExecuteReader())
                {
                    while (sqlRead.Read())
                    {
                        Grantinfo grantinfo = new Grantinfo();
                        grantinfo.ID = (int)sqlRead["ID"];
                        grantinfo.GrantDescription = sqlRead["Description"].ToString();
                        grantinfo.Requirement = sqlRead["Requirements"].ToString();
                        grantinfo.ExpiryDate = (DateTime)sqlRead["Deadline"];
                        grantinfo.Application_Form = sqlRead["Application_Form"].ToString();
                        grantinfo.GrantOfficerId = (int)sqlRead["GrantOfficer"];
                        grantinfo.Title = sqlRead["Title"].ToString();


                        Grant_Controls.ucGrantDisplay ucGrantDisplay = new Grant_Controls.ucGrantDisplay(grantinfo);
                        pnlContainer.Controls.Add(ucGrantDisplay);
                        ucGrantDisplay.Dock = DockStyle.Top;

                    }
                }
            }
        }
        private void FrmGeneralGrantInfo_Load(object sender, EventArgs e)
        {

          //  Size = new Size(1102, 1200);
            DisplayGrantinfo();
           

        }
       
        private void btnGrantHome_Click (object sender, EventArgs e)
        {

            if (!Utils.IsFormOpen(" FrmGeneralGrantInfo"))
            {

                FrmGeneralGrantInfo frmGeneralGrantInfo = new FrmGeneralGrantInfo();
                frmGeneralGrantInfo.MdiParent = this.MdiParent;
                frmGeneralGrantInfo.Show();
            }
            else
            {
                foreach (var form in this.MdiParent.MdiChildren)
                {
                    if (form.Text == " FrmGeneralGrantInfo")
                    {
                        form.BringToFront();
                    }
                }
            }

        }
        
        private void btnApplyforGrant_Click(object sender, EventArgs e)
        {
            if (!Utils.IsFormOpen(" FrmGrantDetails"))
            {

                FrmGrantDetails frmGrantDetails = new FrmGrantDetails();
                frmGrantDetails.MdiParent = this.MdiParent;
                frmGrantDetails.Show();
            }
            else
            {
                foreach (var form in this.MdiParent.MdiChildren)
                {
                    if (form.Text == " FrmGrantDetails")
                    {
                        form.BringToFront();
                    }
                }
            }
           
        }

    }
}