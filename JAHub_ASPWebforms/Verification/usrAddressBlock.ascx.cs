using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JAHub_ASPWebforms.Verification
{
    public partial class usrAddressBlock : System.Web.UI.UserControl
    {
        /* TO DO
         * [x] write custom validation for textboxes with logic 'either all are filled in or none are to be valid'
         */

        public String AddressTown
        {
            get
            {
                return txtAddressTown.Text;
            }
            set
            {
                txtAddressTown.Text = value;
            }
        }
        public String AddressPostOffice
        {
            get
            {
                return txtAddressPostOffice.Text;
            }
            set
            {
                txtAddressPostOffice.Text = value;
            }
        }
        public String AddressParish
        {
            get
            {
                return txtAddressParish.Text;
            }
            set
            {
                txtAddressParish.Text = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public usrAddressBlock()
        {

        }

        public usrAddressBlock(String town, String poBox, String parish)
        {
            txtAddressTown.Text = town;
            txtAddressPostOffice.Text = poBox;
            txtAddressParish.Text = parish;

        }


        public void txtAddressTown_Validating(object sender, ServerValidateEventArgs e)
        {
            if (String.IsNullOrEmpty(txtAddressTown.Text) && (String.IsNullOrEmpty(txtAddressPostOffice.Text) ||
                String.IsNullOrEmpty(txtAddressParish.Text)))
            {
                e.IsValid = true;
                // i would set the isParishValid, but i don't think it's necessary here
            }
            else if (!String.IsNullOrEmpty(txtAddressTown.Text) && (!String.IsNullOrEmpty(txtAddressPostOffice.Text) &&
                !String.IsNullOrEmpty(txtAddressParish.Text)))
            {
                e.IsValid = true;
            }
            else
            {
                e.IsValid = false;
            }
        }

        public void txtAddressPostOffice_Validating(object sender, ServerValidateEventArgs e)
        {
            if (String.IsNullOrEmpty(txtAddressPostOffice.Text) && (String.IsNullOrEmpty(txtAddressTown.Text) ||
                String.IsNullOrEmpty(txtAddressParish.Text)))
            {
                e.IsValid = true;
                // i would set the isParishValid, but i don't think it's necessary here
            }
            else if (!String.IsNullOrEmpty(txtAddressPostOffice.Text) && (!String.IsNullOrEmpty(txtAddressTown.Text) &&
                !String.IsNullOrEmpty(txtAddressParish.Text)))
            {
                e.IsValid = true;
            }
            else
            {
                e.IsValid = false;
            }
        }

        public void txtAddressParish_Validating(object sender, ServerValidateEventArgs e)
        {
            if (String.IsNullOrEmpty(txtAddressParish.Text) && (String.IsNullOrEmpty(txtAddressTown.Text) ||
                String.IsNullOrEmpty(txtAddressPostOffice.Text)))
            {
                e.IsValid = true;
                // i would set the isParishValid, but i don't think it's necessary here
            }
            else if (!String.IsNullOrEmpty(txtAddressParish.Text) && (!String.IsNullOrEmpty (txtAddressTown.Text) &&
                !String.IsNullOrEmpty(txtAddressPostOffice.Text)))
            {
                e.IsValid = true;
            }
            else
            {
                e.IsValid = false;
            }
        }
    }
}