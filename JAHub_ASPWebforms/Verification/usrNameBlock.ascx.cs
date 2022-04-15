using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JAHub_ASPWebforms.Verification
{
    public partial class usrNameBlock : System.Web.UI.UserControl
    {
        // [x] Need to add in properties from other control
        // Need to figure out how to get variables
        // also need to change the format so that it doesn't look so bloody weird
        // why is the css not showing?
        // how do i do validation?

        bool isFirstNameValid;
        bool isMiddleNameValid;
        bool isLastNameValid;

        public String FirstName => txtFirstName.Text;
        public String MiddleName => txtMiddleName.Text;
        public String LastName => txtLastName.Text;


        protected void Page_Load(object sender, EventArgs e)
        {
            // This needs to distinguish between when parameters are set and when it's 
        }
    }
}