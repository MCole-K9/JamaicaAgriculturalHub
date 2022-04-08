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
    public partial class usrNameBlock : UserControl
    {
        bool isFirstNameValid;
        bool isMiddleNameValid;
        bool isLastNameValid;

        public String FirstName => txtFirstName.Text;
        public String MiddleName => txtMiddleName.Text;
        public String LastName => txtLastName.Text;

        public usrNameBlock()
        {
            InitializeComponent();
        }

        public usrNameBlock(String firstName, String middleName, String lastName)
        {
            InitializeComponent();
            txtFirstName.Text = firstName;
            txtMiddleName.Text = middleName;
            txtLastName.Text = lastName;

            isFirstNameValid = true;
            isMiddleNameValid = true;
            isLastNameValid = true;
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                errNameBlock.SetIconAlignment(txtFirstName, ErrorIconAlignment.MiddleRight);
                errNameBlock.SetError(txtFirstName, "Field Cannot be Blank");

                isFirstNameValid = false;
            }
            else
            {
                errNameBlock.SetError(txtFirstName, String.Empty);

                isFirstNameValid = true;
            }
        }

        private void txtMiddleName_Validating(object sender, CancelEventArgs e)
        {
            if (txtMiddleName.Text == "")
            {
                errNameBlock.SetIconAlignment(txtMiddleName, ErrorIconAlignment.MiddleRight);
                errNameBlock.SetError(txtMiddleName, "Field Cannot be Blank");

                isMiddleNameValid = false;
            }
            else
            {
                errNameBlock.SetError(txtMiddleName, String.Empty);

                isMiddleNameValid = true;
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (txtLastName.Text == "")
            {
                errNameBlock.SetIconAlignment(txtLastName, ErrorIconAlignment.MiddleRight);
                errNameBlock.SetError(txtLastName, "Field Cannot be Blank");

                isLastNameValid = false;
            }
            else
            {
                errNameBlock.SetError(txtLastName, String.Empty);

                isLastNameValid = true;
            }
        }

        public bool IsBlockValid()
        {
            if (isFirstNameValid)
            {
                if (isMiddleNameValid)
                {
                    if (isLastNameValid)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public void SetControlFocus()
        {
            if (!isFirstNameValid)
            {
                txtFirstName.Focus();
            }
            else if (!isMiddleNameValid)
            {
                txtMiddleName.Focus();
            }
            else if (!isLastNameValid)
            {
                txtLastName.Focus();
            }
        }
    }
}
