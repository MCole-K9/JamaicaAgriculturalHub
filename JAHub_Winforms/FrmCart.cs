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

namespace JAHub_Winforms
{
    public partial class FrmCart : Form
    {
        public FrmShop _frmShop;
        public FrmCart()
        {
            InitializeComponent();
        }
        public FrmCart(FrmShop frmShop)
        {
            InitializeComponent();
            _frmShop = frmShop;
        }
        public void CaluculateSubtotal(Dictionary<Product, int> cart)
        {
            float total = 0.0f;
            
            foreach (KeyValuePair<Product, int> item in cart)
            {
                total += item.Key.Price * item.Value;
            }

            lblSubTotal.Text = $"Subtotal (Items: {cart.Count}): ${total}" ;
            
        }

        public void LoadCart(Dictionary<Product, int> cart)
        {
            //Makes Keys in the dictionary a list then access the values in the list using foreach-loop 
            foreach (Product item in cart.Keys.ToList())
            {
                Shop_Controls.UcCartItem ucCartItem = new Shop_Controls.UcCartItem(item, this);
                fpnlCart.Controls.Add(ucCartItem);
            }
            
        }

        private void FrmCart_Load(object sender, EventArgs e)
        {
            LoadCart(_frmShop.Cart);

            CaluculateSubtotal(_frmShop.Cart);

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            _frmShop.OpenChildForm(new FrmShippingCheckout(this));
        }
    }
}
