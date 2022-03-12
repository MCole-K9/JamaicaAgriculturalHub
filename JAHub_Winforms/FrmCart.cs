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

        public void LoadCart(List<Product> cart)
        {
            foreach (var item in cart)
            {
                Shop_Controls.UcCartItem ucCartItem = new Shop_Controls.UcCartItem(item, this);
                fpnlCart.Controls.Add(ucCartItem);
            }
            
        }

        private void FrmCart_Load(object sender, EventArgs e)
        {
           LoadCart(_frmShop.Cart);
            
        }
    }
}
