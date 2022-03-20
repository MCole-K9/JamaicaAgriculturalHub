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
    public partial class usrHoldingsBlock : UserControl
    {
        List<bool> isProductListValid;
        List<String> _productsList = new List<String>();

        public String LandAddressTown => usrLandBlock1.LandAddressTown;
        public String LandAddressPoBox => usrLandBlock1.LandAddresssPoBox;
        public String LandAddressParish => usrLandBlock1.LandAddressParish;
        public decimal LandMeasuerement => usrLandBlock1.LandMeasurement;
        public List<String> ProductList => _productsList;

        public usrHoldingsBlock()
        {
            InitializeComponent();
        }

        private void btnAddAnotherProduct_Click(object sender, EventArgs e)
        {
            flwProductsBlock.Controls.Add(new usrProductsBlock());
            btnRemoveLastProduct.Visible = true;
        }

        private void btnRemoveLastProduct_Click(object sender, EventArgs e)
        {
            flwProductsBlock.Controls.RemoveAt(flwProductsBlock.Controls.Count-1);
            
            if (flwProductsBlock.Controls.Count == 1)
            {
                btnRemoveLastProduct.Hide();
            }
        }

        public bool IsBlockValid()
        {
            if (usrLandBlock1.IsBlockValid())
            {
                bool isListValid = true;

                foreach(usrProductsBlock product in flwProductsBlock.Controls)
                {
                    if (product.IsBlockValid())
                    {
                        _productsList.Add(product.Product);
                    }
                    else
                    {
                        isListValid = false;
                        break;
                    }
                }
                
                if (isListValid)
                {
                    return true;
                }

            }
            
            return false;
        }

        public void SetControlFocus()
        {
            // The product blocks will have their own Setcontrol focus
            // so how would i return focus to the relevant control?
            // Possibly: Store an address of an object, "as" it as the kind of control, and 
            // call its .SetControlFocus() method?

        }
    }
}
