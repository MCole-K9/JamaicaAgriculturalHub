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
    public partial class usrAddressBlock : UserControl
    {
        #region Variables and Properties

        bool isTownValid = false;
        bool isPoBoxValid = false;
        bool isParishValid = false;

        public String AddressTown => txtAddressTown.Text;
        public String AddressPostOffice => txtAddressPostOffice.Text;
        public String AddressParish => txtAddressParish.Text;

        #endregion

        public usrAddressBlock()
        {
            InitializeComponent();
        }

        public usrAddressBlock(String town, String poBox, String parish)
        {
            InitializeComponent();
            txtAddressTown.Text = town;
            txtAddressPostOffice.Text = poBox;
            txtAddressParish.Text = parish;
        }

        private void txtAddressTown_Validating(object sender, CancelEventArgs e)
        {
            // validate specifically as "if this is empty while something else is filled flag it
            // else no flag
            if (String.IsNullOrEmpty(txtAddressTown.Text) && (!String.IsNullOrEmpty(txtAddressPostOffice.Text)
                || !String.IsNullOrEmpty(txtAddressParish.Text)))
            {
                errAddressBlock.SetIconAlignment(txtAddressTown, ErrorIconAlignment.MiddleRight);
                errAddressBlock.SetError(txtAddressTown, "Field Cannot be Blank unless the entire address is blank");

                isTownValid = false;
            }
            else
            {
                errAddressBlock.SetError(txtAddressTown, "");

                isTownValid = true;
            }
        }

        private void txtAddressPostOffice_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtAddressPostOffice.Text) && (!String.IsNullOrEmpty(txtAddressTown.Text)
                || !String.IsNullOrEmpty(txtAddressParish.Text)))
            {
                errAddressBlock.SetIconAlignment(txtAddressPostOffice, ErrorIconAlignment.MiddleRight);
                errAddressBlock.SetError(txtAddressPostOffice, "Field Cannot be Blank unless the entire address is blank");

                isPoBoxValid = false;
            }
            else
            {
                errAddressBlock.SetError(txtAddressTown, "");

                isPoBoxValid = true;
            }
        }

        private void txtAddressParish_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtAddressParish.Text) && (!String.IsNullOrEmpty(txtAddressPostOffice.Text)
                || !String.IsNullOrEmpty(txtAddressTown.Text)))
            {
                errAddressBlock.SetIconAlignment(txtAddressParish, ErrorIconAlignment.MiddleRight);
                errAddressBlock.SetError(txtAddressTown, "Field Cannot be Blank unless the entire address is blank");

                isParishValid = false;
            }
            else
            {
                errAddressBlock.SetError(txtAddressParish, "");

                isParishValid = true;
            }
        }

        public bool IsBlockValid()
        {
            if (isTownValid)
            {
                if (isPoBoxValid)
                {
                    if (isParishValid)
                    {
                        return true;
                    }
                }
            }

            return false;

        }

        public void SetControlFocus()
        {
            // this *should* set the focus to the area with the error, if it works properly
            // Bet good money it doesn't work though lol.
            if (!isTownValid)
            {
                txtAddressTown.Focus();
            }
            else if (!isPoBoxValid)
            {
                txtAddressPostOffice.Focus();
            }
            else if (!isParishValid)
            {
                txtAddressParish.Focus();
            }
        }

    }   

    
}
