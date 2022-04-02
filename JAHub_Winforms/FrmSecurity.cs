using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace JAHub_Winforms
{
    public partial class FrmSecurity : Form
    {
        public FrmSecurity()
        {
            InitializeComponent();
        }

        private bool ValidatingOldPassword()
        { 
            bool  check = false;

            if(txtOldPassword.Text == "")
            {
                txtOldPassword.Focus();
                errorProviderOldPassword.SetError(txtOldPassword, "Please enter current password.");
                check = true;
            }
            else
                errorProviderOldPassword.SetError(txtOldPassword, "");
                return check;
        }

        private bool ValidatingNewPassword()
        {
            bool check = false;

            if (txtNewPassword.Text == "") 
            {
                txtNewPassword.Focus();
                errorProviderNewPassword.SetError(txtNewPassword, "Please enter a new password.");
                check = true;
            }
            else
                errorProviderNewPassword.SetError(txtNewPassword, "");
            return check;
        }

        private bool ValidatingConfirmPassword()
        {
            bool check = false;

            if (txtConfirmPassword.Text == "")
            {
                txtConfirmPassword.Focus();
                errorProviderConfirmPassword.SetError(txtConfirmPassword, "Please re-enter new password.");
                check = true;
            }
            else
                errorProviderConfirmPassword.SetError(txtConfirmPassword, "");
            return check;
        }

        //private void CheckOldPassword()
        //{
        //    String mainconn = ConfigurationManager.ConnectionStrings["jamaicaagriculturalhub"].ConnectionString;
        //    SqlConnection connection = new SqlConnection(mainconn);
        //    String Sqlquery = "select * from [dbo].[User] where ID = '" + txtUserId.Text + "' and Password = '" + txtOldPassword.Text + "'";
        //    connection.Open();
        //    SqlCommand sqlcmd = new SqlCommand(Sqlquery, connection);
        //    SqlDataAdapter sda = new SqlDataAdapter(sqlcmd));
        //    DataTable dt = new DataTable();
        //    sda.Fill(dt);
        //    sqlcmd.ExecuteNonQuery();
        //    connection.Close();
        //}

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            //CheckOldPassword();

            //String mainconn = ConfigurationManager.ConnectionStrings["jamaicaagriculturalhub"].ConnectionString;
            //SqlConnection connection = new SqlConnection(mainconn);
            //String sqlquery = "UPDATE [dbo].[User] SET Password = '" + txtConfirmPassword.Text + "' where ID = '" +txtUserID + "'";
            
            //connection.Open();
            //    SqlCommand sqlcmd = new SqlCommand(sqlquery, connection);
            //    SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
            //    DataTable dt = new DataTable();
            //    sda.Fill(dt);
            //    sqlcmd.ExecuteNonQuery();
            //    MessageBox.Show("Your password as changed successfully","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //connection.Close();


            ValidatingOldPassword();
                ValidatingNewPassword();
                ValidatingConfirmPassword();

            }



        }
}
