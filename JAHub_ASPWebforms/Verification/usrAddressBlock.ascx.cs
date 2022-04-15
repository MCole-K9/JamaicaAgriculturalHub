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
        bool isTownValid = false;
        bool isPoBoxValid = false;
        bool isParishValid = false;

        public String AddressTown => txtAddressTown.Text;
        public String AddressPostOffice => txtAddressPostOffice.Text;
        public String AddressParish => txtAddressParish.Text;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void IsBlockValid()
        {
            // Need to know how Page.IsValid affects this
        }

        public void SetControlFocus()
        {
            //SetFocusOnError is relevant to this, but i don't understand it well enough to use it yet
        }
    }
}