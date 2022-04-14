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
    public partial class FrmViewAllMyApplication : Form
    {
        public FrmViewAllMyApplication()
        {
            InitializeComponent();
        }

        private bool isLoggedin = true;
        
       

        private void btnViewAllMyGrants_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                Grantinfo grantinfo = new Grantinfo();
                grantinfo.ViewAllMyGrants();
                connection.Open();

                string query =  $"SELECT * FROM Farmer WHERE ID = {grantinfo.ID}";

                SqlCommand cmd = new SqlCommand(query, connection);
           

                SqlDataReader sqlData = cmd.ExecuteReader();

                while (sqlData.Read())
                {
                    
                    grantinfo.ID = (int)sqlData["ID"];
                    grantinfo.GrantDescription = sqlData["Description"].ToString();
                    grantinfo.Requirement = sqlData["Requirements"].ToString();
                    grantinfo.ExpiryDate = (DateTime)sqlData["Deadline"];
                    grantinfo.ApplicationId = sqlData["Application_Form"].ToString();
                    grantinfo.GrantOfficerId = (int)sqlData["GrantOfficer"];
                    grantinfo.Title = sqlData["Title"].ToString();

                    Grant_Controls.ucGrantDisplay ucGrantDisplay = new Grant_Controls.ucGrantDisplay(grantinfo);
                    pnlContainerAdminViewGrants.Controls.Add(ucGrantDisplay);
                    ucGrantDisplay.Dock = DockStyle.Top;



                }
                sqlData.Close();
            }
        }
        
        }
    }
