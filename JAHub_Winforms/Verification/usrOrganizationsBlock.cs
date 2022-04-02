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
    /* TO DO
     * [x] refactor add and remove organizations buttons to account for passing farmer object?
     * [x] populate the organizations list with the farmer organizations values
     */

    public partial class usrOrganizationsBlock : UserControl
    {
        List<String> _organizations = new List<string>();

        public List<String> Organizations => _organizations;
        public usrOrganizationsBlock()
        {
            InitializeComponent();
        }

        public usrOrganizationsBlock(Farmer farmer)
        {
            InitializeFilledComponent();
            
            foreach (String organization in farmer.Organizations)
            {
                flwOrganizationsTextHolder.Controls.Add(new TextBox());
                flwOrganizationsTextHolder.Controls[flwOrganizationsTextHolder.Controls.Count - 1].
                    Text = organization;
                flwOrganizationsTextHolder.Controls[flwOrganizationsTextHolder.Controls.Count - 1].
                    Size = new System.Drawing.Size(175, 22);
            }
        }


        // This will absolutely need to refactor when I account for the DB/ADO
        private void btnAddAnotherOrganization_Click(object sender, EventArgs e)
        {
            btnRemoveOrganization.Show();

            // this creates a new textbox underneath the one that was there before
            flwOrganizationsTextHolder.Controls.Add(new TextBox());
            flwOrganizationsTextHolder.Controls[flwOrganizationsTextHolder.Controls.Count - 1].Size = new System.Drawing.Size(175, 22);

            Organizations.Add(flwOrganizationsTextHolder.Controls[flwOrganizationsTextHolder.Controls.Count - 1].Text);
        }

        private void btnRemoveOrganization_Click(object sender, EventArgs e)
        {
            flwOrganizationsTextHolder.Controls.RemoveAt(flwOrganizationsTextHolder.Controls.Count - 1);
            Organizations.RemoveAt(Organizations.Count - 1);

            if (flwOrganizationsTextHolder.Controls.Count == 1)
            {
                btnRemoveOrganization.Hide();
            }
        }


    }
}
