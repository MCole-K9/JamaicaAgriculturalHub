using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAHubLib;

namespace JAHub_ASPWebforms.Shop_Controls
{
    public partial class UsrFarmerProduct : System.Web.UI.UserControl
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
                lblAvStock.ID += IDSequence;
                

            }
        }
        private void PopulateFields()
        {
            if (product != null)
            {
                Price.InnerText = product.Price.ToString();
                ProductImage.Src = product.Image;
                lblProductName.InnerText = product.Name;
                lblAvStock.InnerText = $"{product.Stock} Lbs In Stock";
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        protected void btnDelete_ServerClick(object sender, EventArgs e)
        {

        }
    }
}