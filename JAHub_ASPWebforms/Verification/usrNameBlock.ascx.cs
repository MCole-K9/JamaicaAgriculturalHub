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

        public usrNameBlock(String firstName, String middleName, String lastName)
        {
            txtFirstName.Text = firstName;
            txtMiddleName.Text = middleName;
            txtLastName.Text = lastName;

            isFirstNameValid = true;
            isMiddleNameValid = true;
            isLastNameValid = true;
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        // copying the signature of these in case i need them
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