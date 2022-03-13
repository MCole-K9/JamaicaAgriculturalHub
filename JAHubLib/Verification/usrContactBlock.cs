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

namespace JAHubLib.Verification
{
    /* TO-DO
     * [x] write email validation
     * [x] write the code to add a phone number block on click
     * [x] write a method to remove a phone number block when not necessary
     * [] wrap method to wrap all of the information into an object
    */
    public partial class usrContactBlock : UserControl
    {
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
                    contactBlockErrorProvider.SetError(txtEmail, "");
                }
            }
            else if(txtEmail.Text == "")
            {
                contactBlockErrorProvider.SetError(txtEmail, "");
            }
            else
            {
                
                contactBlockErrorProvider.SetIconAlignment(txtEmail, ErrorIconAlignment.MiddleRight);
                contactBlockErrorProvider.SetError(txtEmail, "Must be a valid email, e.g. someone@example.com");
            }
        }

        private void btnAddAnotherPhoneNumber_Click(object sender, EventArgs e)
        {

            flwContactBlock.Controls.Add( new usrPhoneNumberBlock());
            btnRemoveNumber.Visible = true;
            flwContactBlock.Controls.SetChildIndex(flwContactBlock.Controls[flwContactBlock.Controls.Count-1], 3);
        }

        private void btnRemoveNumber_Click(object sender, EventArgs e)
        {
            flwContactBlock.Controls.RemoveAt(flwContactBlock.Controls.Count - 3);
            
            if(flwContactBlock.Controls.Count <= 5)
            {
                btnRemoveNumber.Hide();
            }
        }
    }
}
