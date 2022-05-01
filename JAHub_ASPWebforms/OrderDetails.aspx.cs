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
                order = new Order();

                
                if(Session["LastOrder"] != null)
                {
                    order = (Order)Session["LastOrder"];


                }
                


                
                LoadOrderItems();
                OrderDate.InnerText = order.OrderDate.ToString("dddd, MMMM dd, yyyy");
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