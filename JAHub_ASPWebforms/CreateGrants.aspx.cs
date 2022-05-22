using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAHubLib;



namespace JAHub_ASPWebforms
{
    
    public partial class WebForm1 : System.Web.UI.Page
    {
        Grantinfo grantinfo = new Grantinfo();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
              
            GrantOfficer grantOfficer = new GrantOfficer();
            grantinfo.Application_Form = txtApplicationNumber.Text;
            grantinfo.Title = txtTitle.Text;
            grantinfo.GrantDescription = tAGrantdescription.Value;
            grantinfo.GrantOfficerId = GrantOfficer.FetchGrantOfficerID(JAHubLib.Session.UserId);

            grantinfo.GrantOfficerId = GrantOfficer.FetchGrantOfficerID(JAHubLib.Session.UserId);
            grantinfo.CreateGrant(grantinfo);

            txtApplicationNumber.Text = string.Empty;
            txtTitle.Text = string.Empty;
            tAGrantRequirement.Value = string.Empty;
            tAGrantRequirement.Value = string.Empty;

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}