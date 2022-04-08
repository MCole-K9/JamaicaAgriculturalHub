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

        private bool isLoggedin;
        Grantinfo grantinfo = new Grantinfo();
        private void FrmViewAllMyApplication_Load(object sender, EventArgs e)
        {

            // public void FetchFarmerData()
            //{
            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                string query = isLoggedin ? $"SELECT * FROM Farmer WHERE UserID = {Session.UserId}" : $"SELECT * FROM Farmer WHERE ID = {grantinfo.ID}";

                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataReader sqlData = cmd.ExecuteReader();

                while (sqlData.Read())
                {
                    Grantinfo grantinfo = new Grantinfo();
                    grantinfo.ID = (int)sqlData["ID"];
                    grantinfo.GrantDescription = sqlData["Description"].ToString();
                    grantinfo.Requirement = sqlData["Requirements"].ToString();
                    grantinfo.ExpiryDate = (DateTime)sqlData["Deadline"];
                    grantinfo.ApplicationId = sqlData["Application_Form"].ToString();
                    grantinfo.GrantOfficerId = (int)sqlData["GrantOfficer"];
                    grantinfo.Title = sqlData["Title"].ToString();


                    Grant_Controls.ucGrantDisplay ucGrantDisplay = new Grant_Controls.ucGrantDisplay(grantinfo);
                    pnlContainer.Controls.Add(ucGrantDisplay);
                    ucGrantDisplay.Dock = DockStyle.Top;


                }
                sqlData.Close();
            }
        }
        } 
    }
