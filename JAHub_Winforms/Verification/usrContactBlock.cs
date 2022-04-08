﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JAHubLib;

namespace JAHub_Winforms.Verification
{
    public partial class usrContactBlock : UserControl
    {
        #region Variables and Properties

        bool isEmailValid;
        List<string> _phoneNumbers = new List<string>();

         
        public String Email => txtEmail.Text;
        public List<String> PhoneNumbers;

        #endregion

        /* TO DO
         * - Pass the farmer object to the phone numbers
         */

        public usrContactBlock()
        {
            InitializeComponent();
        }

        public usrContactBlock(Farmer farmer)
        {
            InitializeFilledComponent(farmer);
            txtEmail.Text = farmer.Email;

            foreach (string phoneNumber in farmer.PhoneNumbers)
            {
                flwPhoneNumbers.Controls.Add(new usrPhoneNumberBlock(phoneNumber));
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.IndexOf("@") > -1)
            {
                if (txtEmail.Text.IndexOf(".", txtEmail.Text.IndexOf("@")) > txtEmail.Text.IndexOf("@"))
                {
                    errContactBlock.SetError(txtEmail, "");

                    isEmailValid = true;
                }
            }
            else if(txtEmail.Text == "")
            {
                errContactBlock.SetError(txtEmail, "");

                isEmailValid = true;
            }
            else
            {
                
                errContactBlock.SetIconAlignment(txtEmail, ErrorIconAlignment.MiddleRight);
                errContactBlock.SetError(txtEmail, "Must be a valid email, e.g. someone@example.com");

                isEmailValid = false;
            }
        }

        private void btnAddAnotherPhoneNumber_Click(object sender, EventArgs e)
        {

            flwPhoneNumbers.Controls.Add( new usrPhoneNumberBlock());
            btnRemoveNumber.Visible = true;



        }

        private void btnRemoveNumber_Click(object sender, EventArgs e)
        {
            flwPhoneNumbers.Controls.RemoveAt(flwPhoneNumbers.Controls.Count - 1);
            
            if(flwPhoneNumbers.Controls.Count == 1)
            {
                btnRemoveNumber.Hide();
            }
        }

        public bool IsBlockValid()
        {
            if (isEmailValid)
            {
                bool areAllNumbersValid = true;
                
                foreach(usrPhoneNumberBlock phoneNumber in flwPhoneNumbers.Controls)
                {
                    if (phoneNumber.IsBlockValid())
                    {
                        _phoneNumbers.Add(phoneNumber.PhoneNumber);
                    }
                    else
                    {
                        areAllNumbersValid = false;
                        _phoneNumbers.Clear();

                        break;
                    }
                }

                if (areAllNumbersValid)
                {
                    return true;
                }
            }

            return false;
        }

        public void SetControlFocus()
        {
            if (!isEmailValid)
            {
                txtEmail.Focus();
            }
            else
            {
                foreach(usrPhoneNumberBlock phoneNumber in flwPhoneNumbers.Controls)
                {
                    if (!phoneNumber.IsBlockValid())
                    {
                        phoneNumber.SetControlFocus();
                    }
                }
            }
        }
    }
}
