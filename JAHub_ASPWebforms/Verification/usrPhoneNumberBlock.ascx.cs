using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JAHub_ASPWebforms.Verification
{
    public partial class usrPhoneNumberBlock : System.Web.UI.UserControl
    {
        bool isPhoneNumberValid;
        public String PhoneNumber => txtPhoneNumber.Text;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}