using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using JAHubLib;

namespace JAHub_ASPWebforms
{
    public partial class AddProduct : System.Web.UI.Page
    {
        private Product product;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
                {
                    connection.Open();



                    string query = "Select * From Category";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataSet categoryDS = new DataSet();

                    adapter.Fill(categoryDS, "Category");




                    CategoryDropDown.DataSource = categoryDS.Tables["Category"];

                    CategoryDropDown.DataBind();
                    CategoryDropDown.DataTextField = "CategoryName";
                    CategoryDropDown.DataValueField = "ID";

                    CategoryDropDown.DataBind();
                    CategoryDropDown.Items.Insert(0, new ListItem("Select Category", "NA"));
                }


                if (Session["ProdToEdit"] != null)
                {
                    product = (Product)Session["ProdToEdit"];

                    ProductImage.Src = product.Image;
                    CategoryDropDown.SelectedValue = product.Category.ToString();
                    ProductName.Value = product.Name;
                    Price.Value = product.Price.ToString();
                    Stock.Value = product.Stock.ToString();

                }
            }
            
        }

        protected void btnSave_ServerClick(object sender, EventArgs e)
        {
            try
            {

                if (Session["ProdToEdit"] != null)
                {
                    product = (Product)Session["ProdToEdit"];
                }
                else
                {
                    this.product = new Product();
                }
                  
                    
                if (fupProductImage.HasFile)
                {
                    string tempSavePath = "/Temp/";

                    string fileName = fupProductImage.FileName;

                    tempSavePath += fileName;

                    fupProductImage.SaveAs(Server.MapPath(tempSavePath));

                    product.Image = Util.GetFilePath() + tempSavePath;
                }
              

                product.Name = ProductName.Value;
                product.Category = int.Parse(CategoryDropDown.SelectedValue);
                 
                product.Price = float.Parse(Price.Value);
                product.Stock = int.Parse(Stock.Value);

                Farmer farmer = new Farmer(1);

                if (Session["ProdToEdit"] == null)
                {
                    
                    if (farmer.AddProduct(product) > 0)
                    {
                        Response.Redirect("ManageProducts.aspx");
                    }
                }
                else
                {
                   if(farmer.UpdateProduct(product) > 0)
                   {
                       Response.Redirect("ManageProducts.aspx");
                   }
                }


                

            }
            catch (Exception)
            {

                throw;
            }

            
            


           
        }
    }
}