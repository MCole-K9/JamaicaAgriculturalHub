using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAHubLib;

namespace JAHub_ASPWebforms
{
    public partial class ManageProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Farmer farmer = new Farmer(true);
            LoadProducts(farmer.GetFarmerProducts());   
        }

        public void LoadProducts(List<Product> products)
        {
            pnlFarmerProducts.Controls.Clear();
            //Loop through the product list and renders it on the product form

            int index = 0;
            if(products.Count != 0){

                foreach (var product in products)
                {
                    Shop_Controls.UsrFarmerProduct usrFarmerProduct = (Shop_Controls.UsrFarmerProduct)Page.LoadControl("~/Shop_Controls/UsrFarmerProduct.ascx");
                    usrFarmerProduct.SetProduct(product);
                    usrFarmerProduct.SetIDSequence(index);
                    pnlFarmerProducts.Controls.Add(usrFarmerProduct);

                    index++;
                }

                NPMessage.Attributes.Add("style", "display: none");
            }

        }

        protected void btnAddProduct_ServerClick(object sender, EventArgs e)
        {
            Session["ProdToEdit"] = null;
            Response.Redirect("AddProduct.aspx");
        }
    }
}