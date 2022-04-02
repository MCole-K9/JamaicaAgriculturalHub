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
    public partial class FrmPayment : Form
    {
        private FrmShippingCheckout _shippingCheckout;
        public FrmPayment()
        {
            InitializeComponent();
        }
        public FrmPayment( FrmShippingCheckout frmShippingCheckout)
        {
            InitializeComponent();
            _shippingCheckout = frmShippingCheckout;

        }
        public void CaluculateSubtotal(Dictionary<Product, int> cart)
        {
            float total = 0.0f;

            foreach (KeyValuePair<Product, int> item in cart)
            {
                total += item.Key.Price * item.Value;
            }

            lblCartSubtotal.Text = $" Cart Subtotal (Items: {cart.Count}): ${total}";

        }
        public void LoadOrderSummery()
        {
            //Makes Keys in the dictionary a list then access the values in the list using foreach-loop 
            foreach (Product item in _shippingCheckout._frmCart._frmShop.Cart.Keys.ToList())
            {
                //Passing in Product and Quantity
                Shop_Controls.UsrOrderSumItem usrOrderSumItem = new Shop_Controls.UsrOrderSumItem(item, _shippingCheckout._frmCart._frmShop.Cart[item]);
                fpnlOrderSummery.Controls.Add(usrOrderSumItem);
            }


        }
       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkBillingIsShipping.Checked)
            {
                pnlBillingAddress.Visible = true;
            }
            else
            {
                pnlBillingAddress.Visible = false;
            }
        }

        private void FrmPayment_Load(object sender, EventArgs e)
        {
            LoadOrderSummery();
            CaluculateSubtotal(_shippingCheckout._frmCart._frmShop.Cart);
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void rdbPaypal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPaypal.Checked)
            {
                MessageBox.Show("Click Place Order and We'll  send you on to PayPal so that you can complete your purchase. After the transaction has gone through, the order will be placed. Thank you for Shopping");
            }
            
        }

        private void rdCreditDebitCard_CheckedChanged(object sender, EventArgs e)
        {
            if (rdCreditDebitCard.Checked)
            {
                pnlCardMethod.Visible = true;
            }
            else
            {
                pnlCardMethod.Visible = false;
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            int paymentCardNumber;
            int.TryParse(txtCardNumber.Text, out paymentCardNumber);

            int cvv;
            int.TryParse(txtCVV.Text, out cvv);

            if (rdCreditDebitCard.Checked)
            {
                if (txtCardNumber.Text == "" || paymentCardNumber == 0)
                {
                    MessageBox.Show("Please Enter an Appropriate Card Number");
                    txtCardNumber.Focus();

                }else if(txtExpirationDate.Text == "")
                {
                    MessageBox.Show("Please Enter Expiration Date");
                    txtExpirationDate.Focus();

                }else if(txtCVV.Text == "" || cvv == 0)
                {
                    MessageBox.Show("Please Enter an Appropirate");
                    txtCVV.Focus();

                }else if(txtCardHolderName.Text == "")
                {
                    MessageBox.Show("Please Enter the Card Holder Name");
                    txtCardHolderName.Focus();
                }

            }else if(!chkBillingIsShipping.Checked)
            {
                if(txtFirstName.Text == "")
                {
                    MessageBox.Show("Please Enter First Name");
                    txtFirstName.Focus();

                }else if(txtLastName.Text == "")
                {
                    MessageBox.Show("Please Enter Last Name");
                    txtLastName.Focus();

                }else if(txtStreetAddress.Text == "")
                {
                    MessageBox.Show("Please Enter Street Address");
                    txtStreetAddress.Focus();

                }else if (txtCity.Text == "")
                {
                    MessageBox.Show("Please Enter City");
                    txtCity.Focus();

                }else if(txtParish.Text == "")
                {
                    MessageBox.Show("Please Enter Parish");
                    txtParish.Focus();
                }
            }
           
        }
    }
}
