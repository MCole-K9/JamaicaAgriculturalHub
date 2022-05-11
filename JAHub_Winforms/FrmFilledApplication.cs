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
            Grant_Controls.UserControlGrantSubmission userControlGrantSubmission = new Grant_Controls.UserControlGrantSubmission(grantinfo);  
            pnlGrantSubmission.Controls.Add(userControlGrantSubmission);
            userControlGrantSubmission.Dock = DockStyle.Top;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmFilledApplication_Load(object sender, EventArgs e)
        {
            
            DisplayFilledApplication(grantinfo.GrantOfficerId = GrantOfficer.FetchGrantOfficerID(Session.UserId));
        }

        public void DisplayFilledApplication(int grantApp)
        {
            //grantApp = GrantApplication.GrantApplicationId;
            using (SqlConnection conn = new SqlConnection(Utilities.getConnectionString()))
            {
                conn.Open();
                string query = $"Select * from [Grant] WHERE GrantOfficer = {grantApp}";  
                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader sqlRead = cmd.ExecuteReader())
                {
                    while (sqlRead.Read())
                    {
                        GrantApplication grantApplication = new GrantApplication(); 
                       
                        //grantinfo.ExpiryDate = (DateTime)sqlRead["Deadline"];
                       grantinfo.FileName = sqlRead["Filled_Application"].ToString();
                       


                        Grant_Controls.UserControlGrantSubmission userControlGrantSubmission = new Grant_Controls.UserControlGrantSubmission(grantinfo);
                        pnlGrantSubmission.Controls.Add(userControlGrantSubmission);
                        userControlGrantSubmission.Dock = DockStyle.Top;

                    }
                }
            }
        }
    }
}
