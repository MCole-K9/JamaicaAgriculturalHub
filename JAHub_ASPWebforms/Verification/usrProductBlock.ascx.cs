using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JAHub_ASPWebforms.Verification
{
    public partial class usrProductBlock : System.Web.UI.UserControl
    {
        public String Product
        {
            get
            {
                return txtProduct.Text;
            }
            set
            {
                txtProduct.Text = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        public usrProductBlock()
        {
            // nothing really happens here
        }
    }
}