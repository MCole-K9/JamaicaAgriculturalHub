using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAHubLib;

namespace JAHub_ASPWebforms.Shop_Controls
{
    public partial class UsrOrder : System.Web.UI.UserControl
    {
        private Order order;
        
        int IDSequence;

        public void SetOrder(Order order)
        {
            this.order = order;
        }
        public void SetIDSequence(int id)
        {
            this.IDSequence = id;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
            ShipStreetAdress.InnerText = order.ShipStreetAddress;
            ShipCity.InnerText = order.ShipCity;
            ShipParish.InnerText = order.ShipParish;

            OrderDate.InnerText = order.OrderDate.ToString("dddd, MMMM dd, yyyy");
            Subtotal.InnerText = $"${order.TotalAmount}";

           
        }

        protected void btnViewOrder_ServerClick(object sender, EventArgs e)
        {
            Session["Order"] = this.order;
            Response.Redirect("OrderDetails.aspx");
        }
    }
}