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

        public void ReadFromDatabase(int grantofficerID)
        {
            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                
               /// grantinfo.ViewAllMyGrants();
                connection.Open();
                Grantinfo grantinfo = new Grantinfo();

                // fetch GrantOfficer Table ID

                String query = $"SELECT * FROM [Grant] WHERE GrantOfficer = {grantofficerID}";


                SqlCommand cmd = new SqlCommand(query, connection);


                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    grantinfo.ID =(int)reader["ID"];;
                    grantinfo.requirement = reader["Requirements"].ToString();
                    grantinfo.GrantDescription = reader["Description"].ToString();
                    grantinfo.ExpiryDate = (DateTime)reader["Deadline"];
                    grantinfo.Application_Form = reader["Application_Form"].ToString();
                    grantinfo.GrantOfficerId = (int)reader["GrantOfficer"];
                    grantinfo.Title = reader["Title"].ToString();

                    Grant_Controls.UserControlDisplayGrant userControlDisplayGrant = new Grant_Controls.UserControlDisplayGrant(grantinfo);
                    pnlContainerAdminViewGrants.Controls.Add(userControlDisplayGrant);
                    userControlDisplayGrant.Dock = DockStyle.Top;
                }

                connection.Close();
            }
        }

        
        //Grantinfo grantinfo = new Grantinfo();

        
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

        private void FrmViewAllMyApplication_Load(object sender, EventArgs e)
        {
            Size = new Size(1102, 1200);
            Grantinfo grantinfo = new Grantinfo();
            grantinfo.GrantOfficerId = GrantOfficer.FetchGrantOfficerID(Session.UserId);

            ReadFromDatabase(grantinfo.GrantOfficerId);
        }
    }
}
