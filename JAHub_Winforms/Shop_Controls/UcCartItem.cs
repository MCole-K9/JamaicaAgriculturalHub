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

namespace JAHub_Winforms.Shop_Controls
{
    public partial class UcCartItem : UserControl
    {
        private FrmCart _frmCart;
        private Product _product;
        public UcCartItem(Product product)
        {
            InitializeComponent();
            this._product = product;
        }
        public UcCartItem(Product product, FrmCart frmCart)
        {
            InitializeComponent();
            this._product = product;
            this._frmCart = frmCart;
        }
        public void PopulateFields()
        {
            lblItemName.Text = _product.Name;
            lblPrice.Text = $"${_product.Price} Per Lbs";
            pcbImage.ImageLocation = _product.Image;
            txtQty.Text = Cart.ShoppingCart[this._product].ToString();
        }
        private void UcCartItem_Load(object sender, EventArgs e)
        {
            PopulateFields();

        }


        private void btnPlus_Click(object sender, EventArgs e)
        {
            int qtyValue;
            bool inputIsInt = int.TryParse(txtQty.Text.Trim(), out qtyValue);

            if (inputIsInt)
            {
                qtyValue++;
                txtQty.Text = qtyValue.ToString();
 
            }
            else
            {
                MessageBox.Show("Please Ensure that only a number is inputed");
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int qtyValue;
            bool inputIsInt = int.TryParse(txtQty.Text.Trim(), out qtyValue);

            if (inputIsInt && qtyValue > 0)
            {
               qtyValue--;
               txtQty.Text = qtyValue.ToString();
               
            }
            else
            {
                MessageBox.Show("Please Ensure that only a postitive number is inputed");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            this.Hide();

            //Remove Item From Cart Dictionary
            //this._frmCart._frmShop.Cart.Remove(_product);
            Cart.RemoveFromCart(_product);

            this._frmCart.CaluculateSubtotal(Cart.ShoppingCart);


        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            int qtyValue;
            bool inputIsInt = int.TryParse(txtQty.Text.Trim(), out qtyValue);

            if (inputIsInt && qtyValue > 0)
            {
                txtQty.Text = qtyValue.ToString();

                //Assigns Quantity
                Cart.ShoppingCart[_product] = qtyValue;

                this._frmCart.CaluculateSubtotal(Cart.ShoppingCart);
               
                txtQty.BackColor = Color.White;
            }
            else
            {
                txtQty.BackColor = Color.Red;
            }
        }
    }
}
