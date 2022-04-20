using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JAHub_ASPWebforms.Verification
{
    public partial class usrTrnBlock : System.Web.UI.UserControl
    {
        public String TaxRegistrationNumber => txtTaxRegistrationNumber.Text;

        public bool isTrnValid = false;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public usrTrnBlock()
        {

        }

        public usrTrnBlock(String trn)
        {
            this.txtTaxRegistrationNumber.Text = trn;

            isTrnValid = true;
        }

        protected void cusTaxRegistrationNumber_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if(!Int32.TryParse(txtTaxRegistrationNumber.Text, out int taxRegistrationNumber))
            {
                isTrnValid = false;
            }
        }
    }
}