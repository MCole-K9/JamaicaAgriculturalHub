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
    public partial class FrmShippingCheckout : Form
    {
        private FrmCart _frmCart;
        public FrmShippingCheckout()
        {
            InitializeComponent();
        }
        public FrmShippingCheckout(FrmCart frmCart)
        {
            InitializeComponent();
            _frmCart = frmCart;
        }
        public void LoadOrderSummery()
        {
            //Makes Keys in the dictionary a list then access the values in the list using foreach-loop 
            foreach (Product item in _frmCart._frmShop.Cart.Keys.ToList())
            {
                //Passing in Product and Quantity
                Shop_Controls.UsrOrderSumItem usrOrderSumItem = new Shop_Controls.UsrOrderSumItem(item, _frmCart._frmShop.Cart[item]);
                fpnlOrderSummery.Controls.Add(usrOrderSumItem);
            }

        }

        private void FrmShippingCheckout_Load(object sender, EventArgs e)
        {
            LoadOrderSummery();
        }
    }
}
