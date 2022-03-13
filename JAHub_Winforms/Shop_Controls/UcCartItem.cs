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
            pcbImage.Image = Image.FromFile(_product.Image);
        }
        private void UcCartItem_Load(object sender, EventArgs e)
        {
            PopulateFields();

            // Quantity
            if(_frmCart._frmShop.Cart[_product] < 1)
            {
               this._frmCart._frmShop.Cart[_product] = 1;
            }
            else
            {
                txtQty.Text = this._frmCart._frmShop.Cart[_product].ToString();
            }
            

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int qtyValue;
            bool inputIsInt = int.TryParse(txtQty.Text.Trim(), out qtyValue);

            if (inputIsInt)
            {
                qtyValue++;
                txtQty.Text = qtyValue.ToString();
                this._frmCart._frmShop.Cart[_product] = qtyValue;

                this._frmCart.CaluculateSubtotal(this._frmCart._frmShop.Cart);
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
                //Assigns Quantity
                this._frmCart._frmShop.Cart[_product] = qtyValue;

                this._frmCart.CaluculateSubtotal(this._frmCart._frmShop.Cart);

            }
            else
            {
                MessageBox.Show("Please Ensure that only a postitive number is inputed");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            this.Hide();

            //To-Do: Remove Item From Cart List
            this._frmCart._frmShop.Cart.Remove(_product);

            this._frmCart.CaluculateSubtotal(this._frmCart._frmShop.Cart);


        }
    }
}
