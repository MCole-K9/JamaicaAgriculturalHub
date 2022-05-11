using JAHubLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JAHub_ASPWebforms
{
    public partial class Security : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack) return;

        }

        protected void btnUpdatePassword_Click(object sender, EventArgs e)
        {

            Page.ClientScript.RegisterStartupScript(this.GetType(), "alertFunction", "alert(\"Fill Out All Feilds\")", true);

        }

        private bool ValidatingOldPassword()
        {
            bool check = false;
            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();
                String Sqlquery = $"select * from [dbo].[User] where ID = + {Session["UserId"]} + and Password = '" + txtOldPassword.Text + "'";
                //read on sqldatareader...... check if whats in the text box is same as in the database if ture return t else return false
                SqlDataAdapter sda = new SqlDataAdapter(Sqlquery, connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            return check;
        }
    
            
        


    }
}