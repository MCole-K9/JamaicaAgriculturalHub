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
        private string paymentType = "Credit/Debit Card";
        private Order newOrder;
        public FrmPayment()
        {
            InitializeComponent();
        }
        public FrmPayment( FrmShippingCheckout frmShippingCheckout, Order order)
        {
            InitializeComponent();
            _shippingCheckout = frmShippingCheckout;
            this.newOrder = order;

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
            foreach (Product item in Cart.GetProductsInCart())
            {
                //Passing in Product and Quantity
                Shop_Controls.UsrOrderSumItem usrOrderSumItem = new Shop_Controls.UsrOrderSumItem(item, Cart.ShoppingCart[item]);
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
            CaluculateSubtotal(Cart.ShoppingCart);

            lblName.Text = $"{newOrder.ShipFirstName } {newOrder.ShipLastName}";
            lblEmail.Text = newOrder.ShipEmail;
            lblStreetAddress.Text = newOrder.ShipStreetAddress;
            lblTown.Text = newOrder.ShipCity;
            lblParish.Text = newOrder.ShipParish;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void rdbPaypal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPaypal.Checked)
            {
                Label paypalMessageLabel = new Label();

                paypalMessageLabel.Text = "Click Place Order and We'll send you on to-\nPayPal so that you can complete your purchase.\nAfter the transaction has gone through,\nthe order will be placed.\nThank you for Shopping";
                paypalMessageLabel.Location = new Point(15, 161);
                paypalMessageLabel.Size = new Size(320, 120);
                Font paypalMessageFont = new Font("Microsoft Sans Serif", 10);
                paypalMessageLabel.Font = paypalMessageFont;
                this.Controls.Add(paypalMessageLabel);

                paymentType = "Paypal";
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
                else
                {
                    this.paymentType = "Credit/Debit Card"; //$"Credit/Debit Card ***{txtCardNumber.Text.Substring(11, 4)}";

                }




            }
            if(!chkBillingIsShipping.Checked)
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
                else
                {
                    newOrder.PaymentDetails.BillingFirstName = txtFirstName.Text;
                    newOrder.PaymentDetails.BillingLastName = txtLastName.Text;
                    newOrder.PaymentDetails.BillingEmail = txtEmail.Text;
                    newOrder.PaymentDetails.BillingStreetAddress = txtStreetAddress.Text;
                    newOrder.PaymentDetails.BillingCity = txtCity.Text;
                    newOrder.PaymentDetails.BIllingParish = txtParish.Text;
                }
            }
            else
            {


                if (chkBillingIsShipping.Checked)
                {
                    newOrder.PaymentDetails.BillingFirstName = newOrder.ShipFirstName;
                    newOrder.PaymentDetails.BillingLastName = newOrder.ShipLastName;
                    newOrder.PaymentDetails.BillingEmail = newOrder.ShipEmail; 
                    newOrder.PaymentDetails.BillingStreetAddress = newOrder.ShipStreetAddress;
                    newOrder.PaymentDetails.BillingCity = newOrder.ShipCity;
                    newOrder.PaymentDetails.BIllingParish = newOrder.ShipParish;
                }

                Customer customer = new Customer(true);

                newOrder.PaymentDetails.PaymentType = this.paymentType;

                if (customer.MakeOrder(newOrder) > 0)
                {
                    newOrder.FetchLastOrderData(customer.CustomerID);

                    if (newOrder.WriteOrderItems(Cart.ShoppingCart) > 0)
                    {
                        MessageBox.Show("Order Was Successful");
                    }
                    else
                    {
                        MessageBox.Show("Order Items Error");
                    }
                }
            }

           
        }

        private void pnlBillingAddress_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
