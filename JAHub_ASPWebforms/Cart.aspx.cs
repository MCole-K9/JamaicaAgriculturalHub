using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JAHub_ASPWebforms
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadCart();
        }
        private void LoadCart()
        {
            pnlCart.Controls.Clear();
            int index = 0;

            foreach (var item in JAHubLib.Cart.GetProductsInCart())
            {
                Shop_Controls.UsrCartItem cartItem = (Shop_Controls.UsrCartItem)Page.LoadControl("~/Shop_Controls/UsrCartItem.ascx");
                cartItem.SetProduct(item);
                cartItem.SetIDSequence(index);
                pnlCart.Controls.Add(cartItem);

                index++;
            }
            CartSum();
        }

        public void CartSum()
        {
            subtotal.InnerText = JAHubLib.Cart.CaluculateTotal().ToString();
            itemCount.InnerText = JAHubLib.Cart.ShoppingCart.Count().ToString();
        }

        protected void btnCheckout_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("Checkout.aspx");
        }
    }
}