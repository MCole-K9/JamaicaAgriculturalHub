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
    /* TO-DO
     * [x] Put all phone numbers in their own block
     * [x] Rewrite add and remove buttons to put new phone blocks in the new container
     * [] expose values inside 
    */
    public partial class usrContactBlock : UserControl
    {
        bool isEmailValid;
        List<bool> isPhoneValid;

        public String Email => txtEmail.Text;
        public List<String> PhoneNumbers;

        public usrContactBlock()
        {
            InitializeComponent();
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.IndexOf("@") > -1)
            {
                if (txtEmail.Text.IndexOf(".", txtEmail.Text.IndexOf("@")) > txtEmail.Text.IndexOf("@"))
                {
                    errContactBlock.SetError(txtEmail, "");

                    isEmailValid = true;
                }
            }
            else if(txtEmail.Text == "")
            {
                errContactBlock.SetError(txtEmail, "");

                isEmailValid = true;
            }
            else
            {
                
                errContactBlock.SetIconAlignment(txtEmail, ErrorIconAlignment.MiddleRight);
                errContactBlock.SetError(txtEmail, "Must be a valid email, e.g. someone@example.com");

                isEmailValid = false;
            }
        }

        private void btnAddAnotherPhoneNumber_Click(object sender, EventArgs e)
        {

            flwPhoneNumbers.Controls.Add( new usrPhoneNumberBlock());
            btnRemoveNumber.Visible = true;
        }

        private void btnRemoveNumber_Click(object sender, EventArgs e)
        {
            flwPhoneNumbers.Controls.RemoveAt(flwContactBlock.Controls.Count - 1);
            
            if(flwPhoneNumbers.Controls.Count == 1)
            {
                btnRemoveNumber.Hide();
            }
        }

        public bool IsBlockValid()
        {
            if (isEmailValid)
            {
                bool areAllNumbersValid = true;
                
                //foreach (){
                    // this needs me to expose the phone numbers first, then do it
                    
                //}

                if (areAllNumbersValid)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
