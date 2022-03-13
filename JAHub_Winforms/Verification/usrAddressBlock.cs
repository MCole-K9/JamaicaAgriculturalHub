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
    public partial class usrAddressBlock : UserControl
    {
        public usrAddressBlock()
        {
            InitializeComponent();
        }

        private void txtAddressTown_Validating(object sender, CancelEventArgs e)
        {
            // validate specifically as "if this is empty while something else is filled flag it
            // else no flag
            if (String.IsNullOrEmpty(txtAddressTown.Text) && (!String.IsNullOrEmpty(txtAddressPostOffice.Text)
                || !String.IsNullOrEmpty(txtAddressParish.Text)))
            {
                addressBlockErrorProvider.SetIconAlignment(txtAddressTown, ErrorIconAlignment.MiddleRight);
                addressBlockErrorProvider.SetError(txtAddressTown, "Field Cannot be Blank unless the entire address is blank");
            }
            else
            {
                addressBlockErrorProvider.SetError(txtAddressTown, "");
            }
        }

        private void txtAddressPostOffice_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtAddressPostOffice.Text) && (!String.IsNullOrEmpty(txtAddressTown.Text)
                || !String.IsNullOrEmpty(txtAddressParish.Text)))
            {
                addressBlockErrorProvider.SetIconAlignment(txtAddressPostOffice, ErrorIconAlignment.MiddleRight);
                addressBlockErrorProvider.SetError(txtAddressPostOffice, "Field Cannot be Blank unless the entire address is blank");
            }
            else
            {
                addressBlockErrorProvider.SetError(txtAddressTown, "");
            }
        }

        private void txtAddressParish_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtAddressParish.Text) && (!String.IsNullOrEmpty(txtAddressPostOffice.Text)
                || !String.IsNullOrEmpty(txtAddressTown.Text)))
            {
                addressBlockErrorProvider.SetIconAlignment(txtAddressParish, ErrorIconAlignment.MiddleRight);
                addressBlockErrorProvider.SetError(txtAddressTown, "Field Cannot be Blank unless the entire address is blank");
            }
            else
            {
                addressBlockErrorProvider.SetError(txtAddressParish, "");
            }
        }
    }
}
