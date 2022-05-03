using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAHubLib;

namespace JAHub_ASPWebforms
{
    public partial class Checkout : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadOrderSummery();
        }
        public void LoadOrderSummery()
        {

            pnlOrderSummery.Controls.Clear();
            int index = 0;

            foreach (var item in JAHubLib.Cart.GetProductsInCart())
            {
                Shop_Controls.UsrOrderSumItem orderSumItem = (Shop_Controls.UsrOrderSumItem)Page.LoadControl("~/Shop_Controls/UsrOrderSumItem.ascx");
                orderSumItem.SetProduct(item);
                orderSumItem.SetIDSequence(index);
                pnlOrderSummery.Controls.Add(orderSumItem);

                index++;
            }

            CartCount.InnerText = JAHubLib.Cart.ShoppingCart.Count.ToString();
            Subtotal.InnerText = $"${JAHubLib.Cart.CaluculateTotal()}";
        }

        protected void btnPlaceOrder_ServerClick(object sender, EventArgs e)
        {
            Order order = new Order();

            order.ShipStreetAddress = ShipStreetAdress.Value;
            order.ShipCity = ShipCity.Value;
            order.ShipParish = ShipParish.Value;

            if(bool.Parse(hidBillingIsShipping.Value))
            {
                order.PaymentDetails.BillingStreetAddress = order.ShipStreetAddress;
                order.PaymentDetails.BillingCity = order.ShipCity;
                order.PaymentDetails.BIllingParish = order.ShipParish;
            }
            else
            {
                order.PaymentDetails.BillingStreetAddress = BillingStreetAdress.Value;
                order.PaymentDetails.BillingCity = BillingCity.Value;
                order.PaymentDetails.BIllingParish = BIllingParish.Value;
            }
            order.PaymentDetails.PaymentType = hidPaymentMethod.Value;

            Customer customer = new Customer(true);


            if (customer.MakeOrder(order) > 0)
            {
                order.FetchLastOrderData(customer.CustomerID);

                if (order.WriteOrderItems(JAHubLib.Cart.ShoppingCart) > 0)
                {
                   
                    Session["LastOrder"] = order;
                    Response.Redirect("OrderDetails.aspx");
                }
                else
                {
                    //Something Went Wrong
                }
            }

        }
    }
}