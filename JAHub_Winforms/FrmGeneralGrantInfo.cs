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

        private void FrmGeneralGrantInfo_Load(object sender, EventArgs e)
        {

            Size = new Size(1102, 1200);
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
                        grantinfo.ApplicationId = sqlRead["Application_Form"].ToString();
                        grantinfo.GrantOfficerId = (int)sqlRead["GrantOfficer"];
                        grantinfo.Title = sqlRead["Title"].ToString();


                        Grant_Controls.ucGrantDisplay ucGrantDisplay = new Grant_Controls.ucGrantDisplay(grantinfo);
                        pnlContainer.Controls.Add(ucGrantDisplay);
                        ucGrantDisplay.Dock = DockStyle.Top;

                    }
                }
            }
        }

        private void btnBlogs_Click(object sender, EventArgs e)
        {

            FrmGeneralGrantInfo frmGeneralGrantInfo = new FrmGeneralGrantInfo();
            frmGeneralGrantInfo.Show();
            /* FrmViewAllMyApplication frmViewMyApplication = new FrmViewAllMyApplication();
              Grantinfo grantinfo = new Grantinfo();
              frmViewMyApplication.Show();*/

        }

        private void pnlLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCreateBlog_Click(object sender, EventArgs e)
        {

        }
      

        private void btncreatetesting_Click(object sender, EventArgs e)
        {
            FrmCreateGrant frmCreateGrant = new FrmCreateGrant();
            frmCreateGrant.Show();
        }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteGrant_Click(object sender, EventArgs e)
        {

        }

        private void btncreatetesting_Click(object sender, EventArgs e)
        {
            FrmCreateGrant frmCreateGrant = new FrmCreateGrant();
            frmCreateGrant.Show();
        }

        private void btnViewall_Click(object sender, EventArgs e)
        {
            FrmViewAllMyApplication frmViewAllMyApplication = new FrmViewAllMyApplication();    
            frmViewAllMyApplication.Show(); 
        }
    }
}
