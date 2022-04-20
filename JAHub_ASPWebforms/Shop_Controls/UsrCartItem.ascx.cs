using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAHubLib;

namespace JAHub_ASPWebforms.Shop_Controls
{
    public partial class UsrCartItem : System.Web.UI.UserControl
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

            if (!IsPostBack)
            {

                PopulateFields();
                Price.ID += IDSequence;
                ProductImage.ID += IDSequence;
                lblProductName.ID += IDSequence;
                txtQuantity.Text = JAHubLib.Cart.ShoppingCart[product].ToString();

            }
        }

        private void PopulateFields()
        {
            if(product != null)
            {
                Price.InnerText = product.Price.ToString();
                ProductImage.Src = product.Image;
                lblProductName.InnerText = product.Name;
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        protected void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            float qty;
            float.TryParse(txtQuantity.Text, out qty);

            if(qty > 0)
            {
                JAHubLib.Cart.UpdateProductQuantity(this.product, (int)qty);

            }
        }

        protected void btnDelete_ServerClick(object sender, EventArgs e)
        {
            JAHubLib.Cart.RemoveFromCart(this.product);
 
            Response.Redirect(Request.RawUrl);

        }
    }
}