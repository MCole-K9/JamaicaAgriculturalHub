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
using JAHub_Winforms.Verification;

namespace JAHub_Winforms
{
    public partial class FrmAdminEditUser : Form
    {
        User _user;
        FrmAdminContainer _frmAdmin;
        bool isPasswordValid = true;
        bool isEmailValid = true;
        usrNameBlock nameBlock;
        public FrmAdminEditUser(int userId, FrmAdminContainer admin)
        {
            InitializeComponent();
            TopLevel = false;
            _frmAdmin = admin;

            _user = new User();
            _user.ReadFromDatabase(userId);

            // I want to show the middle initial, but it's not important rn
            lblEditUser.Text = $"Edit User: {_user.FirstName} {_user.LastName}" +
                $" (ID: {_user.UserID}; Role: {_user.UserRole})";

            // This adds and moves-to-top the usrNameBlock
            flwControlsHolder.Controls.Add(new usrNameBlock(_user.FirstName, _user.MiddleName, 
                _user.LastName));
            flwControlsHolder.Controls.SetChildIndex(
                flwControlsHolder.Controls[flwControlsHolder.Controls.Count - 1], 0);

            nameBlock = flwControlsHolder.Controls[0] as usrNameBlock;

            txtEmail.Text = _user.Email;

            txtPasswordFirstEntry.Text = _user.Password;
            txtPasswordSecondEntry.Text = _user.Password;
        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            nameBlock.Validate();

            Boolean areEntriesValid = false;

            if (nameBlock.IsBlockValid())
            {
                if (isEmailValid)
                {
                    if (nameBlock.IsBlockValid())
                    {
                        if (isPasswordValid)
                        {
                            areEntriesValid = true;

                            _user.FirstName = nameBlock.FirstName;
                            _user.LastName = nameBlock.LastName;
                            _user.MiddleName = nameBlock.MiddleName;

                            _user.Email = txtEmail.Text.ToLower();
                            _user.Password = txtPasswordFirstEntry.Text;

                            _user.UpdateUserRecord();
                        }
                    }
                }
            }

            if (areEntriesValid == false)
            {
                MessageBox.Show("Cannot Edit User Record. One or More Errors Exist. Please fix them to" +
                    " Continue");
            }
            else
            {
                MessageBox.Show("Successfully modified record!");
                _frmAdmin.OpenSelectCurrentUser();

            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.IndexOf("@") > -1)
            {
                if (txtEmail.Text.IndexOf(".", txtEmail.Text.IndexOf("@")) > txtEmail.Text.IndexOf("@"))
                {
                    errEditUser.SetError(txtEmail, "");

                    isEmailValid = true;
                }
            }
            else if (txtEmail.Text == "")
            {
                errEditUser.SetIconAlignment(txtEmail, ErrorIconAlignment.MiddleRight);
                errEditUser.SetError(txtEmail, "Field Cannot be Blank");

                isEmailValid = false;
            }
            else
            {

                errEditUser.SetIconAlignment(txtEmail, ErrorIconAlignment.MiddleRight);
                errEditUser.SetError(txtEmail, "Must be a valid email, e.g. someone@example.com");

                isEmailValid = false;
            }
        }

        private void txtPasswordFirstEntry_Validating(object sender, CancelEventArgs e)
        {
            if (txtPasswordFirstEntry.Text == "")
            {
                errEditUser.SetIconAlignment(txtPasswordFirstEntry, ErrorIconAlignment.MiddleRight);
                errEditUser.SetError(txtPasswordFirstEntry, "Password must be entered");

                return;
            }
            else
            {
                errEditUser.SetError(txtPasswordFirstEntry, "");
            }
        }

        private void txtPasswordSecondEntry_Validating(object sender, CancelEventArgs e)
        {
            if (txtPasswordFirstEntry.Text == "")
            {
                errEditUser.SetIconAlignment(txtPasswordFirstEntry, ErrorIconAlignment.MiddleRight);
                errEditUser.SetError(txtPasswordFirstEntry, "Password must be entered");
                isPasswordValid = false;

                return;
            }
            else if (txtPasswordSecondEntry.Text != txtPasswordFirstEntry.Text)
            {
                errEditUser.SetIconAlignment(txtPasswordSecondEntry, ErrorIconAlignment.MiddleRight);
                errEditUser.SetError(txtPasswordSecondEntry, "Passwords must match");
                isPasswordValid = false;
            }
            else if (txtPasswordSecondEntry.Text == txtPasswordFirstEntry.Text)
            {
                errEditUser.SetError(txtPasswordSecondEntry, "");
                isPasswordValid = true;
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPasswordFirstEntry.PasswordChar = '\0';
                txtPasswordSecondEntry.PasswordChar = '\0';
            }
            else
            {
                txtPasswordFirstEntry.PasswordChar = '*';
                txtPasswordSecondEntry.PasswordChar = '*';
            }
        }
    }
}
