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

namespace JAHub_Winforms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtUserId.Text) && String.IsNullOrEmpty(txtPassword.Text))
            {
                lblCredentialEntryError.Text = "Please enter both the UserId and Password and try" +
                    " " + " again.";
                lblCredentialEntryError.Show();

            }
            
            // This is only necessary because i'm working with the assumption that the code
            // uses userID and not username. Probably will change
            else if (Int32.TryParse(txtUserId.Text, out int id) == false)
            {
                lblCredentialEntryError.Text = "Error: UserID must be a number";
                lblCredentialEntryError.Show();

                txtUserId.Clear();
            }
            else if ((Int32.TryParse(txtUserId.Text, out int userID) == true) && String.IsNullOrEmpty(txtPassword.Text))
            {
                PasswordResult result = Session.Login(Int32.Parse(txtUserId.Text), txtPassword.Text);

                if (result == PasswordResult.Success)
                {
                    if (lblCredentialEntryError.Visible == true)
                    {
                        lblCredentialEntryError.Visible = false;
                    }
                    
                    // Session is now set to whatever role and ID the user has
                    // unfreeze all controls
                }
                else if (result == PasswordResult.CredentialsIncorrect)
                {
                    lblCredentialEntryError.Text = "UserID or Password is incorrect, please check your" +
                        " " + "credentials and try again";

                    txtPassword.Clear();
                    lblCredentialEntryError.Show();
                }
                else if (result == PasswordResult.NoMatchingCredentials)
                {
                    lblCredentialEntryError.Text = "UserID not found, please check your credentials" +
                        " " + "or register for an account";

                    txtPassword.Clear();
                    lblCredentialEntryError.Show();
                }
            }
            
            
            /* This needs to:
             * - Lock all controls in parent *except this box* until user/pass is filled
             * - if match:
             *  - unlock all controls
             *  - show controls according to user role
             *  - could potentially have a "3 strikes and you're out" policy, this is secondary
             * 
             */
        }
    }
}
