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

        bool isTownValid = false;
        bool isPoBoxValid = false;
        bool isParishValid = false;

        public String AddressTown => txtAddressTown.Text;
        public String AddressPostOffice => txtAddressPostOffice.Text;
        public String AddressParish => txtAddressParish.Text;

        protected void Page_Load(object sender, EventArgs e)
        {
            
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
            //SetFocusOnError is relevant to this, but i don't understand it well enough to use it yet
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