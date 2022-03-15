using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAHub_Winforms.Verification
{
    public partial class usrOrganizationsBlock : UserControl
    {
        public usrOrganizationsBlock()
        {
            InitializeComponent();
        }

        // This will absolutely need to refactor when I account for the DB/ADO
        private void btnAddAnotherOrganization_Click(object sender, EventArgs e)
        {
            btnRemoveOrganization.Show();

            // this creates a new textbox underneath the one that was there before
            flwOrganizationsTextHolder.Controls.Add(new TextBox());
            flwOrganizationsTextHolder.Controls[flwOrganizationsTextHolder.Controls.Count - 1].Size = new System.Drawing.Size(175, 22);
        }

        private void btnRemoveOrganization_Click(object sender, EventArgs e)
        {
            flwOrganizationsTextHolder.Controls.RemoveAt(flwOrganizationsTextHolder.Controls.Count - 1);
                        
            if (flwOrganizationsTextHolder.Controls.Count == 1)
            {
                btnRemoveOrganization.Hide();
            }
        }
    }
}
