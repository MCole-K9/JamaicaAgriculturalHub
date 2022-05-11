using JAHubLib;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JAHub_ASPWebforms
{
    public partial class MyAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();
                string sqlquary = $"select FirstName+ ' ' +LastName as FullName, Gender, EmailAddress from [dbo].[User] where ID =  {Session["UserId"]}";
                SqlCommand cmd = new SqlCommand(sqlquary, connection);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    lblFullName.Text = sdr.GetValue(0).ToString();
                    lblGender.Text = sdr.GetValue(1).ToString();
                    lblEmail.Text = sdr.GetValue(2).ToString();
                    lbl
                }
                sdr.Close();
            }
        }


    }
}