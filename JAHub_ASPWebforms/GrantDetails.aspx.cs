using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAHubLib;

namespace JAHub_ASPWebforms
{
   
    public partial class Grantdetails : System.Web.UI.Page
    {
        Grantinfo grantinfo = new Grantinfo();

        //Grantdetails(Grantinfo g)
        //{
        //    grantinfo = g;
        //    tAGrantdescription.Value = g.GrantDescription;
        //    tAGrantRequirement.Value = g.Requirement;
        //    //txtApplicationNumber.Text = g.Application_Form;
        //    txtTitle.Text = g.Title;    

        //}
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}