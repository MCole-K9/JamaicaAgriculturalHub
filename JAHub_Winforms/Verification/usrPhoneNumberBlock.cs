using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAHub_Winforms.Verification
{
    public partial class usrPhoneNumberBlock : UserControl
    {
        bool isPhoneNumberValid;
        public usrPhoneNumberBlock()
        {
            InitializeComponent();
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

        public bool IsPhoneNumberValid()
        {
            if (isPhoneNumberValid)
            {
                return true;
            }
            return false;
        }
    }
}
