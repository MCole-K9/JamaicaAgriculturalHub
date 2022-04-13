﻿using System;
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
        }
        private void UcCartItem_Load(object sender, EventArgs e)
        {
            PopulateFields();

            // Quantity
            //Defualt Quntity value is 1, code below stops the quantity from being set to 1 if it was already changed
            //Quantiy Retention While Browsering the application
            if(_frmCart._frmShop.Cart[_product] < 1)
            {
               this._frmCart._frmShop.Cart[_product] = 1;
            }
            else
            {
                txtQty.Text = this._frmCart._frmShop.Cart[_product].ToString();
            }
            

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
            this._frmCart._frmShop.Cart.Remove(_product);

            this._frmCart.CaluculateSubtotal(this._frmCart._frmShop.Cart);


        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            int qtyValue;
            bool inputIsInt = int.TryParse(txtQty.Text.Trim(), out qtyValue);

            if (inputIsInt && qtyValue > 0)
            {
                txtQty.Text = qtyValue.ToString();

                //Assigns Quantity
                this._frmCart._frmShop.Cart[_product] = qtyValue;

                this._frmCart.CaluculateSubtotal(this._frmCart._frmShop.Cart);
               
                txtQty.BackColor = Color.White;
            }
            else
            {
                txtQty.BackColor = Color.Red;
            }
        }
    }
}
