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
     * [x] actually populate a list of Products
     */
    public partial class usrProductsBlock : UserControl
    {
        bool isProductValid;

        public String Product => txtProduct.Text;

        public usrProductsBlock()
        {
            InitializeComponent();
        }

        public usrProductsBlock(string farmerProduct)
        {
            InitializeComponent();
            txtProduct.Text = farmerProduct;
            txtProduct.Enabled = false;

            isProductValid = true;
        }

        private void txtProduct_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtProduct.Text)){
                errProductsBlock.SetIconAlignment(txtProduct, ErrorIconAlignment.MiddleRight);
                errProductsBlock.SetError(txtProduct, "Field cannot be blank");

                isProductValid = false;
            }
            else
            {
                errProductsBlock.SetError(txtProduct, "");

                isProductValid = true;
            }
        }

        public bool IsBlockValid()
        {
            if (isProductValid)
            {
                return true;
            }

            return false;
        }

        public void SetControlFocus()
        {
            txtProduct.Select();
        }
    }
}
