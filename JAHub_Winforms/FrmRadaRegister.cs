using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JAHub_Winforms.Verification;

namespace JAHub_Winforms
{
    public partial class FrmRadaRegister : Form
    {
        public FrmRadaRegister()
        {
            InitializeComponent();
        }

        private void btnNewRegistration_Click(object sender, EventArgs e)
        {
            // Clear and add all of the relevant user controls
        }

        private void btnConnectExistingAccount_Click(object sender, EventArgs e)
        {
            if (flwFormEntryControls.Controls.Count > 3)
            {
                flwFormEntryControls.Controls.Clear();
                flwFormEntryControls.Controls.Add(new usrNameBlock());
                flwFormEntryControls.Controls.Add(new usrDateOfBirthBlock());
                flwFormEntryControls.Controls.Add(new usrTrnBlock());
            }
        }
    }
}
