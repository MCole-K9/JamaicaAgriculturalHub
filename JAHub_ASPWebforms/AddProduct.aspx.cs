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
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
            {
                connection.Open();


                if (!IsPostBack)
                {

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

            }
        }

        protected void btnSave_ServerClick(object sender, EventArgs e)
        {
            try
            {
                string tempSavePath = "/Temp/";

                if (fupProductImage.HasFile)
                {
                    string fileName = fupProductImage.FileName;

                    tempSavePath += fileName;

                    fupProductImage.SaveAs(Server.MapPath(tempSavePath));
                }
                Product product = new Product
                {
                    Name = ProductName.Value,
                    Category = int.Parse(CategoryDropDown.SelectedValue),
                    Image = Util.GetFilePath()+tempSavePath,
                    Price = float.Parse(Price.Value),
                    Stock = int.Parse(Stock.Value),

                };

                Farmer farmer = new Farmer(1);
                if(farmer.AddProduct(product) > 0)
                {
                    Response.Redirect("ManageProducts.aspx");
                }

            }
            catch (Exception)
            {

                throw;
            }

            
            


           
        }
    }
}