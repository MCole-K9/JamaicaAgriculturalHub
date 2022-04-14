using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAHubLib;

namespace JAHub_ASPWebforms
{
    public partial class ProductDetail : System.Web.UI.Page
    {
        Product product;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.product = (Product)Session["ProductDetail"];
            PopulateFields();
        }
        private void PopulateFields()
        {
            imgProduct.Src = product.Image;
            lblProductName.InnerText = product.Name;
            lblProductPrice.InnerText = $"${product.Price} Per Lbs";
        }
    }
}