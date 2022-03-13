using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAHub_Winforms.Verification
{
    public partial class usrProductsBlock : UserControl
    {
        /* TO-DO
         * [] write the validation for if a product gets added
         * [] write the method to wrap entered values into some kind of collection
         */
        public usrProductsBlock()
        {
            InitializeComponent();
        }

        private void txtProduct_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtProduct.Text)){
                productsBlockErrorProvider.SetIconAlignment(txtProduct, ErrorIconAlignment.MiddleRight);
                productsBlockErrorProvider.SetError(txtProduct, "Field cannot be blank");
            }
            else
            {
                productsBlockErrorProvider.SetError(txtProduct, "");
            }
        }
    }
}
