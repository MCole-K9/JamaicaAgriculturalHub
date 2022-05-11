using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAHubLib;

namespace JAHub_ASPWebforms
{
    public partial class Orders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer customer = new Customer(true);

            LoadOrders(customer.GetOrders());

        }
        public void LoadOrders(List<Order> orders)
        {
            pnlOrders.Controls.Clear();
            int index = 0;
            foreach (var order in  orders)
            {
                Shop_Controls.UsrOrder usrOrder = (Shop_Controls.UsrOrder)Page.LoadControl("~/Shop_Controls/UsrOrder.ascx");
                usrOrder.SetOrder(order);
                usrOrder.SetIDSequence(index);
                pnlOrders.Controls.Add(usrOrder);

                index++;
            }
        }
    }
}