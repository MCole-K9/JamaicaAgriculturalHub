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

        public usrOrganizationsBlock(List<string> organizations)
        {
            InitializeFilledComponent();
            
            foreach (String organization in organizations)
            {
                flpOrganizationsTextHolder.Controls.Add(new TextBox());
                flpOrganizationsTextHolder.Controls[flpOrganizationsTextHolder.Controls.Count - 1].
                    Text = organization;
                flpOrganizationsTextHolder.Controls[flpOrganizationsTextHolder.Controls.Count - 1].
                    Size = new System.Drawing.Size(175, 22);
            }
            btnAddAnotherOrganization.Visible = false;
        }


        // This will absolutely need to refactor when I account for the DB/ADO
        private void btnAddAnotherOrganization_Click(object sender, EventArgs e)
        {
            btnRemoveOrganization.Show();

            // this creates a new textbox underneath the one that was there before
            flpOrganizationsTextHolder.Controls.Add(new TextBox());
            flpOrganizationsTextHolder.Controls[flpOrganizationsTextHolder.Controls.Count - 1].Size = new System.Drawing.Size(400, 22);

            Organizations.Add(flpOrganizationsTextHolder.Controls[flpOrganizationsTextHolder.Controls.Count - 1].Text);
        }

        private void btnRemoveOrganization_Click(object sender, EventArgs e)
        {
            flpOrganizationsTextHolder.Controls.RemoveAt(flpOrganizationsTextHolder.Controls.Count - 1);
            Organizations.RemoveAt(Organizations.Count - 1);

            if (flpOrganizationsTextHolder.Controls.Count == 1)
            {
                btnRemoveOrganization.Hide();
            }
        }


    }
}
