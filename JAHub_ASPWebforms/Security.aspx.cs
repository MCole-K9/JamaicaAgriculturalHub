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
            if (!IsPostBack)
            {
                Clear();
            }

        }

        protected void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            if (ValidatingOldPassword() == false)
            {
                lblMessage.Visible = true;
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Password provided not correct.";
                
            }
            else
            {
                lblMessage.Visible = false;
                using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
                {
                    String sqlquery = $"UPDATE [dbo].[User] SET Password = '{txtConfirmPassword.Text}' where ID = { Session["UserId"]}";
                    connection.Open();
                    SqlCommand sqlcmd = new SqlCommand(sqlquery, connection);
                    SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    sqlcmd.ExecuteNonQuery();
                }

                Clear();

                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertFunction", "alert(\"Password changed successfully.\")", true);
            }

           

        }

        private bool ValidatingOldPassword()
        {
            bool check = false;
            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();
                String Sqlquery = $"select * from [dbo].[User] where ID = {Session["UserId"]} and Password = '{txtOldPassword.Text}'";
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

        public void Clear()
        {
            txtOldPassword.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
        }


        

        protected void CustomValidatorOldPassword_ServerValidate(object source, ServerValidateEventArgs args)
        {
               
        }


    }
}