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
    public partial class UsrOrderItem : UserControl
    {
        private OrderItem orderItem;
        public UsrOrderItem()
        {
            InitializeComponent();
        }
        public UsrOrderItem(OrderItem orderItem)
        {
            InitializeComponent();
            this.orderItem = orderItem; 
        }

        private void PopulateFields()
        {
            lblItemName.Text = orderItem.OrderProduct.Name;
            lblPrice.Text = $"{orderItem.OrderProduct.Price}/Lbs";
            lblQty.Text += orderItem.Quantity.ToString();
            lblTotal.Text = $"${orderItem.Quantity * orderItem.OrderProduct.Price}";
            pcbImage.ImageLocation = orderItem.OrderProduct.Image;
        }

        private void UsrOrderItem_Load(object sender, EventArgs e)
        {
            PopulateFields();
        }
    }
}
