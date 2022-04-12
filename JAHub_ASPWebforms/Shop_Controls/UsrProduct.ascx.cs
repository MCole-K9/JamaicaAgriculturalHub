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
        private int ImageIDSequence;
        public void SetProduct(Product product)
        {
            this.product = product;
        }
        public void SetImageIDSequence(int ID)
        {
            this.ImageIDSequence = ID;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductImage.ID += ID;

            ProductImage.ImageUrl =$"~/{product.Image}";
            
    

            
        }
    }
}