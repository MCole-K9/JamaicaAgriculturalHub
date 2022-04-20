using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JAHub_ASPWebforms.Verification
{
    public partial class usrOrganizationsBlock : System.Web.UI.UserControl
    {
        List<String> _organizations = new List<string>();

        public List<String> Organizations => _organizations;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public usrOrganizationsBlock()
        {

        }

        public usrOrganizationsBlock(List<string> organizations)
        {
            _organizations = organizations;

            foreach(string organization in _organizations)
            {
                TextBox textbox = new TextBox();
                textbox.Text = organization;

                phOrganizatons.Controls.Add(textbox);
            }
        }


        protected void btnAddAnotherOrganization_Click(object sender, EventArgs e)
        {
            if (btnRemoveOrganization.CssClass.Contains("invisible"))
            {
                btnRemoveOrganization.CssClass = "btn btn-default";
            }

            phOrganizatons.Controls.Add(new TextBox());
        }

        protected void btnRemoveOrganization_Click(object sender, EventArgs e)
        {
            if(phOrganizatons.Controls.Count <= 1)
            {
                btnRemoveOrganization.CssClass = "btn btn-default invisible";
            }

            phOrganizatons.Controls.RemoveAt(phOrganizatons.Controls.Count - 1);
        }
    }
}