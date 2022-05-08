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

        public bool UsesHeavyMachinery
        {
            get
            {
                return _usesHeavyMachinery;
            }
            set
            {
                _usesHeavyMachinery = value;
                if (_usesHeavyMachinery)
                {
                    rdoIndustryYes.Checked = true;
                    rdoIndustryNo.Checked = false;
                }
                else
                {
                    rdoIndustryYes.Checked = false;
                    rdoIndustryNo.Checked = true;
                }
            }
        }
        public decimal NumberOfEmployees
        {
            get
            {
                return Decimal.Parse(txtNumberOfEmployees.Text);
            }
            set
            {
                txtNumberOfEmployees.Text = value.ToString();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public usrIndustryBlock()
        {

        }

        protected void cusNumberOfEmployees_ServerValidate(object source, ServerValidateEventArgs args)
        {
            // validate the number of employees, duh
        }

        protected void cusRadioButtons_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if(rdoIndustryNo.Checked == false && rdoIndustryYes.Checked == false)
            {
                args.IsValid = false;
            }
            else
            {
                args.IsValid = true;
            }
        }
    }
}