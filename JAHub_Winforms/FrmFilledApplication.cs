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
    public partial class FrmFilledApplication : Form
    {
        GrantApplication grantApplication = new GrantApplication();
        Grantinfo grantinfo = new Grantinfo();
        //GrantApplication GrantApplication = new GrantApplication();
        public FrmFilledApplication()
        {
            InitializeComponent();
        }

        public FrmFilledApplication(Grantinfo gr)
        {
          grantinfo = gr;
          
          
        }


        private void btngrantHome_Click(object sender, EventArgs e)
        {
            Grant_Controls.UserControlGrantSubmission userControlGrantSubmission = new Grant_Controls.UserControlGrantSubmission(grantApplication);  
            pnlGrantSubmission.Controls.Add(userControlGrantSubmission);
            userControlGrantSubmission.Dock = DockStyle.Top;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmFilledApplication_Load(object sender, EventArgs e)
        {
            grantApplication.GrantApplicationId = GrantOfficer.FetchGrantOfficerID(Session.UserId);
            DisplayFilledApplication(grantApplication.GrantApplicationId);
        }
        

       
        public void DisplayFilledApplication(int grant_Application)
        {   
            //grantApp = GrantApplication.GrantApplicationId;
            using (SqlConnection conn = new SqlConnection(Utilities.getConnectionString()))
            {
                conn.Open();
                string query = $"Select * from [Grant_application] WHERE [Grant] = {grant_Application}";  
                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader sqlRead = cmd.ExecuteReader())
                {
                    while (sqlRead.Read())
                    {

                        //grantinfo.ExpiryDate = (DateTime)sqlRead["Deadline"];
                        //grantinfo.FileName = sqlRead["Filled_Application"].ToString();
                        grantApplication.ID = (int)sqlRead["ID"];
                       // grantApplication.TimeStamp = (DateTime)sqlRead["TimeStamp"];
                        grantApplication.GrantApplicationId = (int)sqlRead["Grant"];
                        grantApplication.FilledApplication = sqlRead["Filled_Application"].ToString();


                        
                        Grant_Controls.UserControlGrantSubmission userControlGrantSubmission = new Grant_Controls.UserControlGrantSubmission(grantApplication);
                        pnlGrantSubmission.Controls.Add(userControlGrantSubmission);
                        userControlGrantSubmission.Dock = DockStyle.Top;

                    }
                }
            }
        }

        private void btnUpdateGrant_Click(object sender, EventArgs e)
        {

        }

        //grantApplication.GrantApplicationId = GrantOfficer.FetchGrantOfficerID(Session.UserId);
    }
}
