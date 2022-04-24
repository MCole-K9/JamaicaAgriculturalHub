using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
    }
}