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

        public String FirstName
        {
            get
            {
                return txtFirstName.Text;
            }
            set
            {
                txtFirstName.Text = value;
            }
        }
        public String MiddleName
        {
            get
            {
                return txtMiddleName.Text;
            }
            set
            {
                txtMiddleName.Text = value;
            }
        }
        public String LastName
        {
            get
            {
                return txtLastName.Text;
            }
            set
            {
                txtLastName.Text = value;
            }
        }


        public usrNameBlock()
        {

        }


        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public void SetControlFocus()
        {
            //SetFocusOnError is relevant to this, but i don't understand it well enough to use it yet
        }
    }
}