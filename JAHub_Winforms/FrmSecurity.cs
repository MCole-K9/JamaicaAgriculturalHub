using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            ValidatingOldPassword();
            ValidatingNewPassword();    
            ValidatingConfirmPassword();
            
        }


        
    }
}
