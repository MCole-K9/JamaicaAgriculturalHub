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
    /* TO-DO
     * [x] Write the flag for if the number isn't entered (validating)
     * ~[~] Figure out the Regex for number validation
     * [x] figure out how to create a number mask for a phone
    */

    public partial class usrPhoneNumberBlock : UserControl
    {
        public usrPhoneNumberBlock()
        {
            InitializeComponent();
        }

        private void mskPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            // this doesn't validate properly for some reason, but i'm skipping it
            if (mskPhoneNumber.MaskFull)
            {
                numberErrorProvider.SetError(mskPhoneNumber, "");
            }
            else
            {
                numberErrorProvider.SetIconAlignment(mskPhoneNumber, ErrorIconAlignment.MiddleRight);
                numberErrorProvider.SetError(mskPhoneNumber, "Please enter a valid number");
            }
        }
    }
}
