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
using JAHubLib;

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

            if (txtOldPassword.Text == "")
            {
                txtOldPassword.Focus();
                errorProviderOldPassword.SetError(txtOldPassword, "Please enter current password.");
                check = false;
            }
            else
            {
                errorProviderOldPassword.Clear();
                //uary database get password from database "select from user where session,id......."
                SqlConnection connection = new SqlConnection(Utilities.getConnectionString());
                connection.Open();
                String Sqlquery = "select * from [dbo].[User] where ID = " + Session.UserId + " and Password = '" + txtOldPassword.Text + "'";
                //read on suldatareader...... check if whats in the text box is same as in the database if ture return t else return false
                SqlDataAdapter sda = new SqlDataAdapter(Sqlquery, connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    check = true;
                }
                else
                {
                    errorProviderOldPassword.SetError(txtOldPassword, "Password not Matched.");
                    txtOldPassword.Focus();
                    check = false;
                }

                connection.Close();
                //check = true;

                //errorProviderOldPassword.Clear();

            }
            return check;
        }

        private bool ValidatingNewPassword()
        {
            bool check = false;

            if (txtNewPassword.Text == "") 
            {
                txtNewPassword.Focus();
                errorProviderNewPassword.SetError(txtNewPassword, "Please enter a new password.");
                check = false;
                
            }
            else
            {
                errorProviderNewPassword.Clear();
                check = true;
            }
                
            return check;
        }

        private bool ValidatingConfirmPassword()
        {
            bool check = false;

            if (txtConfirmPassword.Text == "")
            {
                txtConfirmPassword.Focus();
                errorProviderConfirmPassword.SetError(txtConfirmPassword, "Please re-enter new password.");
                check=false;
                
            }
            else if (txtNewPassword.Text == txtConfirmPassword.Text)
            {
                SqlConnection connection = new SqlConnection(Utilities.getConnectionString());
                String sqlquery = "UPDATE [dbo].[User] SET Password = '" + txtConfirmPassword.Text + "' where ID = '" + Session.UserId + "'";

                connection.Open();
                SqlCommand sqlcmd = new SqlCommand(sqlquery, connection);
                SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Your password as changed successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                connection.Close();
                check = true;
            }
            else if(txtNewPassword.Text != txtConfirmPassword.Text)
            {
                errorProviderConfirmPassword.SetError(txtConfirmPassword, "Conform password doesn't match New password");
                txtConfirmPassword.ForeColor = System.Drawing.Color.Red;
                check = false;
            }
            else if (ValidatingOldPassword())
            {
                check = false;
            }
            else
            {
                errorProviderConfirmPassword.Clear();
                txtConfirmPassword.ForeColor = System.Drawing.Color.Black;

            }
                
            return check;
        }


        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            bool UpdateSuccess = false;
            if (ValidatingOldPassword()  && ValidatingNewPassword()  && ValidatingConfirmPassword() == true)
            {
                txtConfirmPassword.Clear();
                txtNewPassword.Clear();
                txtOldPassword.Clear();
                UpdateSuccess = true;

            }
            else
            {
                MessageBox.Show("Failed to Update");
                UpdateSuccess = false;

            }
               
                

        }
    }
}
