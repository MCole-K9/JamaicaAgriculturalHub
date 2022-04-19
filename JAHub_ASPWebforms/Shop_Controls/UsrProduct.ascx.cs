using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAHubLib;

namespace JAHub_ASPWebforms.Shop_Controls
{
    public partial class UsrProduct : System.Web.UI.UserControl
    {
        private Product product;
        private int IDSequence;
        public void SetProduct(Product product)
        {
            this.product = product;
        }
        public void SetImageIDSequence(int ID)
        {
            this.IDSequence = ID;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductImage.ID += IDSequence;
            ProductName.ID += IDSequence;
            ProductPrice.ID += IDSequence;
            btnViewProduct.ID += IDSequence;

            ProductImage.Src =$"~/{product.Image}";

            
            ProductName.InnerText = product.Name;
            ProductPrice.InnerText = $"${product.Price} Per Lbs";
            
        }

        protected void btnViewProduct_ServerClick(object sender, EventArgs e)
        {
            Session["ProductDetail"] = this.product;
            Response.Redirect("~/ProductDetail.aspx");
        }

        protected void btnAddToCart_ServerClick(object sender, EventArgs e)
        {
            try
            {
                JAHubLib.Cart.AddToCart(this.product, 1);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            

        }
    }
}