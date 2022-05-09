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
    public partial class Signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Clear();
            }
           
        }


        protected void btnsubmit_serverclick(object sender, EventArgs e)   //need to fix... two submit buttens are confilcting
        {
            if (CheckifEmailExist() == false) ///not working
            {
                lblMessage.Visible = true;
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Use another email, this email already exist.";
            }
            else
            {
                
                using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SignupUser", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                    cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text.Trim());
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Gender", Gender.SelectedValue);  //need to fix
                    cmd.Parameters.AddWithValue("@EmailAddress", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", txtConfirmPassword.Text.Trim());
                    cmd.Parameters.AddWithValue("@UserRole", 2);
                    cmd.ExecuteNonQuery();

                    //Page.ClientScript.RegisterStartupScript(this.GetType(), "alertFunction", "alert(\"Account created successfully\",clickLoginNavBtn()", true);

                    Clear();
                    lblMessage.Visible = true;
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                    lblMessage.Text = "Account created successfully. You can now login.";
                   
                }
            }

        }


        public void Clear()
        {
            txtFirstName.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtConfirmPassword.Text = "";
            txtPassword.Text = "";
            //Gender.Value = "";
        }


        public bool CheckifEmailExist()
        {
            bool chk;
            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();
                String Sqlquery = $"select * from [dbo].[User] where EmailAddress = '{txtEmail.Text}'";
                SqlDataAdapter sda = new SqlDataAdapter(Sqlquery, connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    chk = false;
                }
                else
                {
                    chk = true;
                }
                return chk;
            }
            
        }

    }
}