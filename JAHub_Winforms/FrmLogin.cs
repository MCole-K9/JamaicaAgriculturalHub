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
        FrmMainWindow parent;
        
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtEmailAddress.Text) || String.IsNullOrEmpty(txtPassword.Text))
            {
                lblCredentialEntryError.Text = "Please enter both the Email Address and Password and try" +
                    " " + " again.";
                lblCredentialEntryError.Show();
            }
            else if (!String.IsNullOrEmpty(txtEmailAddress.Text) && !String.IsNullOrEmpty(txtPassword.Text))
            {
                PasswordResult result = Session.Login(txtEmailAddress.Text.ToLower(), txtPassword.Text);

                if (result == PasswordResult.Success)
                {
                    if (lblCredentialEntryError.Visible == true)
                    {
                        lblCredentialEntryError.Hide();
                    }

                    parent = this.MdiParent as FrmMainWindow;
                    parent.UnlockControls();

                    this.Close();
                }
                else if (result == PasswordResult.CredentialsIncorrect)
                {
                    lblCredentialEntryError.Text = "Email Address or Password is incorrect, please check your" +
                        " " + "credentials and try again";

                    txtPassword.Clear();
                    lblCredentialEntryError.Show();
                }
                else if (result == PasswordResult.NoMatchingCredentials)
                {
                    lblCredentialEntryError.Text = "Email Address not found, please check your credentials" +
                        " " + "or register for an account";

                    txtPassword.Clear();
                    lblCredentialEntryError.Show();
                }
            }
            
            /* This needs to:
             *  - could potentially have a "3 strikes and you're out" policy, this is secondary
             * 
             */
        }
    }
}
