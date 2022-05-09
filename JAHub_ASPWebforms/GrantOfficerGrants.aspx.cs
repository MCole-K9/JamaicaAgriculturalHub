using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAHubLib;
using System.Data.SqlClient;

namespace JAHub_ASPWebforms
{
    public partial class GrantOfficerGrants : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Grantinfo grantinfo = new Grantinfo();
            grantinfo.GrantOfficerId = GrantOfficer.FetchGrantOfficerID(JAHubLib.Session.UserId);

            ReadFromDatabase(grantinfo.GrantOfficerId);
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
                    grantinfo.ID = (int)reader["ID"]; ;
                    grantinfo.requirement = reader["Requirements"].ToString();
                    grantinfo.GrantDescription = reader["Description"].ToString();
                    grantinfo.ExpiryDate = (DateTime)reader["Deadline"];
                    grantinfo.Application_Form = reader["Application_Form"].ToString();
                    grantinfo.GrantOfficerId = (int)reader["GrantOfficer"];
                    grantinfo.Title = reader["Title"].ToString();

                    /*Grant_Controls.UserControlDisplayGrant userControlDisplayGrant = new Grant_Controls.UserControlDisplayGrant(grantinfo);
                    pnlContainerAdminViewGrants.Controls.Add(userControlDisplayGrant);
                    userControlDisplayGrant.Dock = DockStyle.Top;*/
                }

                connection.Close();
            }
        }
    }
}