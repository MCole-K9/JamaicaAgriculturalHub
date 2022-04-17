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
        bool isProductValid;

        public String Product => txtProduct.Text;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        public usrProductBlock()
        {
            // nothing really happens here
        }

        public usrProductBlock(string farmerProduct)
        {
            txtProduct.Text = farmerProduct;

            isProductValid = true;
        }

        private void txtProduct_Validating(object sender)//, CancelEventArgs e)
        {
            //if (String.IsNullOrEmpty(txtProduct.Text))
            {
                //errProductsBlock.SetIconAlignment(txtProduct, ErrorIconAlignment.MiddleRight);
                //errProductsBlock.SetError(txtProduct, "Field cannot be blank");

                //isProductValid = false;
            }
            //else
            {
                //errProductsBlock.SetError(txtProduct, "");

                //isProductValid = true;
            }
        }

        public bool IsBlockValid()
        {
            //if (isProductValid)
            {
                //return true;
            }

            return false;
        }

        public void SetControlFocus()
        {
            //txtProduct.Select();
        }
    }
}