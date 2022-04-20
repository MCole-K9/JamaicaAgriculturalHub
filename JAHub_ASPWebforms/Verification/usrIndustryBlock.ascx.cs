using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAHubLib;

namespace JAHub_ASPWebforms.Verification
{
    public partial class usrIndustryBlock : System.Web.UI.UserControl
    {
        bool isChoiceSelected;
        bool _usesHeavyMachinery;

        public bool UsesHeavyMachinery => _usesHeavyMachinery;
        public decimal NumberOfEmployees => Decimal.Parse(txtNumberOfEmployees.Text);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public usrIndustryBlock()
        {

        }

        public usrIndustryBlock(Farmer farmer)
        {
            // assign values, duh
        }

        protected void cusNumberOfEmployees_ServerValidate(object source, ServerValidateEventArgs args)
        {
            // validate the number of employees, duh
        }
    }
}