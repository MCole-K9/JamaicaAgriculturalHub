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
    public partial class UsrOrderSumItem : UserControl
    {
        private Product product;
        private int quantity;
        public UsrOrderSumItem()
        {
            InitializeComponent();
        }
        public UsrOrderSumItem(Product product, int quantity)
        {
            InitializeComponent();
            this.product = product;
            this.quantity = quantity;
        }

        public void PopulateFields()
        {
            pbImage.ImageLocation = product.Image;
            lblItemName.Text = product.Name;
            lblPrice.Text = $"${product.Price} / lbs";
            lblQty.Text = $"Qty: {quantity}";
        }

        private void UsrOrderSumItem_Load(object sender, EventArgs e)
        {
            PopulateFields();
        }
    }
}
