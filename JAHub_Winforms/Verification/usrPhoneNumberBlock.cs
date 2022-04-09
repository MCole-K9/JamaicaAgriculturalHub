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

namespace JAHub_Winforms.Verification
{
    /* TO DO
     * [x] actually populate the list of phone numbers using the farmer object
     */
    public partial class usrPhoneNumberBlock : UserControl
    {
        bool isPhoneNumberValid;
        public String PhoneNumber => mskPhoneNumber.Text;

        public usrPhoneNumberBlock()
        {
            InitializeComponent();
        }

        public usrPhoneNumberBlock(string PhoneNumber)
        {
            InitializeComponent();
            mskPhoneNumber.Text = PhoneNumber;

            isPhoneNumberValid = true;
        }

        private void mskPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            // this doesn't validate properly for some reason, but i'm skipping it
            if (mskPhoneNumber.MaskFull)
            {
                errPhoneNumber.SetError(mskPhoneNumber, "");

                isPhoneNumberValid = true;
            }
            else
            {
                errPhoneNumber.SetIconAlignment(mskPhoneNumber, ErrorIconAlignment.MiddleRight);
                errPhoneNumber.SetError(mskPhoneNumber, "Please enter a valid number");

                isPhoneNumberValid = false;
            }
        }

        public bool IsBlockValid()
        {
            if (isPhoneNumberValid)
            {
                return true;
            }
            return false;
        }

        public void SetControlFocus()
        {
            mskPhoneNumber.Focus();
        }
    }
}
