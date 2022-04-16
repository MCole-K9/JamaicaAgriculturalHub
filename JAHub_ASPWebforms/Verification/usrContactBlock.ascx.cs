using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JAHub_ASPWebforms.Verification
{
    public partial class usrContactBlock : System.Web.UI.UserControl
    {
        /* TO DO
         * [] add in some way of putting the values of phone numbers into the list
         * */
        
        bool isEmailValid;
        List<string> _phoneNumbers = new List<string>();

        public String Email => txtEmail.Text;
        public List<String> PhoneNumbers => _phoneNumbers;
        protected void Page_Load(object sender, EventArgs e)
        {
            // here is probably where i distinguish between parameter add and non params
        }

        protected void btnAddPhoneNumber_Click(object sender, EventArgs e)
        {
            phPhoneNumbers.Controls.Add(LoadControl("~/Verification/usrPhoneNumberBlock"));

            if(phPhoneNumbers.Controls.Count > 1)
            {
                btnRemovePhoneNumber.Visible = true;
            }
        }

        protected void btnRemovePhoneNumber_Click(object sender, EventArgs e)
        {
            phPhoneNumbers.Controls.Remove(phPhoneNumbers.Controls[Controls.Count - 1]);

            if(phPhoneNumbers.Controls.Count <= 1)
            {
                btnRemovePhoneNumber.Visible = false;
            }
        }
    }
}