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
    public partial class Grants : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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


                       // GrantDisplay_Controls.GeneralGrantInfo ucGrantDisplay = new GrantDisplay_Controls.GeneralGrantInfo(grantinfo);
                       /* Panel.Controls.Add(ucGrantDisplay);
                        ucGrantDisplay.Dock = DockStyle.Top;*/

                    }
                }
            }
        }
    }
}