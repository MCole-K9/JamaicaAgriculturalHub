using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAHubLib;

namespace JAHub_ASPWebforms.Shop_Controls
{
    public partial class UsrOrderSumItem : System.Web.UI.UserControl
    {
        Product product;
        int IDSequence;
        public void SetProduct(Product product)
        {
            this.product = product;
        }
        public void SetIDSequence(int id)
        {
            this.IDSequence = id;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductImage.Src = product.Image;
            ProductName.InnerText = product.Name;
            ProductPrice.InnerText = $"${JAHubLib.Cart.CostOfProductOrder(this.product)}";
            Quantity.InnerText = $"Qty: {JAHubLib.Cart.ShoppingCart[this.product]}";

            ProductImage.ID += IDSequence;
            ProductName.ID += IDSequence;
            ProductPrice.ID += IDSequence;
            Quantity.ID += IDSequence;
        }
    }
}