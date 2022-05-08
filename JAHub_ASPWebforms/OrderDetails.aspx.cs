using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAHubLib;

namespace JAHub_ASPWebforms
{
    public partial class OrderDetails : System.Web.UI.Page
    {
        private Order order;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                
                if(Session["LastOrder"] != null)
                {
                    order = (Order)Session["LastOrder"];


                }else if(Session["Order"] != null)
                {
                    order = (Order)Session["Order"];
                    order.FetchOrderItems();
                }
                else
                {
                    //Error
                }


                
                if(this.order != null)
                {
                    ShipStreetAdress.InnerText = order.ShipStreetAddress;
                    ShipCity.InnerText = order.ShipCity;
                    ShipParish.InnerText = order.ShipParish;

                    PaymentMethod.InnerText = order.PaymentDetails.PaymentType;
                    BillingStreetAddress.InnerText = order.PaymentDetails.BillingStreetAddress;
                    BillingCity.InnerText = order.PaymentDetails.BillingCity;
                    BillingParish.InnerText = order.PaymentDetails.BIllingParish;

                    Subtotal.InnerText = $"${order.TotalAmount}"; 

                    LoadOrderItems();
                    OrderDate.InnerText = order.OrderDate.ToString("dddd, MMMM dd, yyyy");
                }

                
                
            }
           
        }

        private void LoadOrderItems()
        {
            pnlOrderItems.Controls.Clear();
            int index = 0;
            foreach (var item in this.order.Items)
            {
                Shop_Controls.UsrOrderItem orderItem = (Shop_Controls.UsrOrderItem)Page.LoadControl("~/Shop_Controls/UsrOrderItem.ascx");
                orderItem.SetOItem(item);
                orderItem.SetIDSequence(index);
                pnlOrderItems.Controls.Add(orderItem);
                index++;
            }
        }
    }
}