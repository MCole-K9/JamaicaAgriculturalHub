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
        public FrmCart _frmCart;
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
            foreach (Product item in Cart.GetProductsInCart())
            {
                //Passing in Product and Quantity
                Shop_Controls.UsrOrderSumItem usrOrderSumItem = new Shop_Controls.UsrOrderSumItem(item, Cart.ShoppingCart[item]);
                fpnlOrderSummery.Controls.Add(usrOrderSumItem);
            }

        }

        private void FrmShippingCheckout_Load(object sender, EventArgs e)
        {
            LoadOrderSummery();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(txtEmailAddress.Text == "")
            {
                MessageBox.Show("Please Enter Email Address");
                txtEmailAddress.Focus();
            }
            else if (txtFirstName.Text == "")
            {
                MessageBox.Show("Please Enter First Name");
                txtFirstName.Focus();

            }
            else if (txtLastName.Text == "")
            {
                MessageBox.Show("Please Enter Last Name");
                txtLastName.Focus();

            }
            else if (txtStreetAddress.Text == "")
            {
                MessageBox.Show("Please Enter Street Address");
                txtStreetAddress.Focus();

            }
            else if (txtCity.Text == "")
            {
                MessageBox.Show("Please Enter City");
                txtCity.Focus();

            }
            else if (txtParish.Text == "")
            {
                MessageBox.Show("Please Enter Parish");
                txtParish.Focus();
            }
            else
            {
                Order newOrder = new Order();
                newOrder.ShipFirstName = txtFirstName.Text;
                newOrder.ShipLastName = txtLastName.Text;
                newOrder.ShipEmail = txtEmailAddress.Text;
                newOrder.ShipStreetAddress = txtStreetAddress.Text;
                newOrder.ShipCity = txtCity.Text;
                newOrder.ShipParish = txtParish.Text;

                _frmCart._frmShop.OpenChildForm(new FrmPayment(this, newOrder));
            }
            
        }
    }
}
