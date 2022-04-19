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
    public partial class UcProduct : UserControl
    {
        private FrmProducts _frmProducts;
        private Product product;

        public UcProduct(Product product)
        {
            InitializeComponent();
            this.product = product;

        }
        public UcProduct(Product product, FrmProducts frmProducts)
        {
            InitializeComponent();
            this.product = product;
            this._frmProducts = frmProducts;

        }
        public void PopulateFields()
        {
            lblItemName.Text = product.Name;
            lblPrice.Text = $"${product.Price} Per Lbs";
            pcbImage.ImageLocation = product.Image;
        }

        private void UcProduct_Load(object sender, EventArgs e)
        {
            PopulateFields();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                Cart.AddToCart(this.product, 1);
                //this._frmProducts._frmShop.Cart.Add(product, 1);
            }
            catch (ArgumentException)
            {

                MessageBox.Show("This Item is already in your cart");
            }
            
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this._frmProducts._frmShop.OpenProductDetails(product);
        }
    }
}
