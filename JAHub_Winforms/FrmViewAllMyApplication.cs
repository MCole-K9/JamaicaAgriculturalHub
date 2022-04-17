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

        public void ReadFromDatabase(int userId)
        {
            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                Grantinfo grantinfo = new Grantinfo();
                grantinfo.ViewAllMyGrants();
                connection.Open();

                // fetch GrantOfficer Table ID

                String query = $"SELECT * FROM [Grant] WHERE GrantOfficer = {userId}";


                SqlCommand cmd = new SqlCommand(query, connection);


                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    grantinfo.ID = userId;
                    grantinfo.requirement = reader["Requirements"].ToString();
                    grantinfo.GrantDescription = reader["Description"].ToString();
                    grantinfo.ExpiryDate = (DateTime)reader["Deadline"];
                    grantinfo.ApplicationId = reader["Application_Form"].ToString();
                    grantinfo.GrantOfficerId = (int)reader["GrantOfficer"];
                    grantinfo.Title = reader["Title"].ToString();

                    Grant_Controls.ucGrantDisplay ucGRantDisplay = new Grant_Controls.ucGrantDisplay(grantinfo);
                    pnlContainerAdminViewGrants.Controls.Add(ucGRantDisplay);
                    ucGRantDisplay.Dock = DockStyle.Top;
                }

                connection.Close();
            }
        }

        private bool isLoggedin;
        Grantinfo grantinfo = new Grantinfo();

        private void FrmViewAllMyApplication_Load(object sender, EventArgs e)
        {
            Size = new Size(1102, 1200);
            Grantinfo grantinfo = new Grantinfo();
            grantinfo.GrantOfficerId = GrantOfficer.FetchGrantOfficerID(Session.UserId);

            ReadFromDatabase(grantinfo.GrantOfficerId);
        }

        //private void pnlGrantDeleteContainer_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
            //const string message = "Are you sure you wish to delete this grant?";
            //const string caption = "Deleting Grant";
            //var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            
            //SqlDataReader sqlData = cmd.ExecuteReader();

            //while (sqlData.Read())
                //{
                    
                    //grantinfo.ID = (int)sqlData["ID"];
                    //grantinfo.GrantDescription = sqlData["Description"].ToString();
                    //grantinfo.Requirement = sqlData["Requirements"].ToString();
                    //grantinfo.ExpiryDate = (DateTime)sqlData["Deadline"];
                    //grantinfo.ApplicationId = sqlData["Application_Form"].ToString();
                    //grantinfo.GrantOfficerId = (int)sqlData["GrantOfficer"];
                    //grantinfo.Title = sqlData["Title"].ToString();

                    //Grant_Controls.ucGrantDisplay ucGrantDisplay = new Grant_Controls.ucGrantDisplay(grantinfo);
                    //pnlContainerAdminViewGrants.Controls.Add(ucGrantDisplay);
                    //ucGrantDisplay.Dock = DockStyle.Top;

            //if (result == DialogResult.Yes)
            //{
                //Grantinfo grantinfo = new Grantinfo();
                //int J = grantinfo.ID;
                //grantinfo.DeleteGrant(J);



                //}
                //sqlData.Close();
            //}
        //}

        private void btnViewAllMyGrants_Click(object sender, EventArgs e)
        {

        }
        
    }
}
