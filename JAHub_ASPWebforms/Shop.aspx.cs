using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using JAHubLib;

namespace JAHub_ASPWebforms
{
    public partial class Shop : System.Web.UI.Page
    {
        List<Product> products;
        protected void Page_Load(object sender, EventArgs e)
        {
            products = new List<Product>();

            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();

                string query = "Select * from Product";

                SqlCommand cmd = new SqlCommand(query, connection);

                using (SqlDataReader sqlData = cmd.ExecuteReader())
                {
                    while (sqlData.Read())
                    {
                        Product product = new Product();

                        product.Id = (int)sqlData["ID"];
                        product.Name = sqlData["Name"].ToString();
                        product.Stock = (int)sqlData["Stock"];
                        product.Price = float.Parse(sqlData["Price"].ToString());
                        product.Image = $@"Images\{sqlData["Image"].ToString()}";
                        product.Farmer = new Farmer((int)sqlData["Farmer"]);
                        product.Category = (int)sqlData["Category"];
                        products.Add(product);

                    }
                }
            }

            LoadProducts(products);
        }
        public void LoadProducts(List<Product> products)
        {
            pnlProducts.Controls.Clear();
            //Loop through the product list and renders it on the product form

            int index = 0;
            foreach (var product in products)
            {
                Shop_Controls.UsrProduct usrProduct = (Shop_Controls.UsrProduct)Page.LoadControl("~/Shop_Controls/UsrProduct.ascx");
                usrProduct.SetProduct(product);
                usrProduct.SetImageIDSequence(index);
                pnlProducts.Controls.Add(usrProduct);

                index++;
            }

        }
    }
}