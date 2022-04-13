using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace JAHubLib
{
    public class Product
    {
        private int id;
        private string name;
        private string description;
        private int category;
        private string image;
        private float price;
        private int stock;
        private List<Review> reviews = new List<Review>();
        private Farmer farmer;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int Category { get => category; set => category = value; }
        public string Image { get => image; set => image = value; }
        public float Price { get => price; set => price = value; }
        
        public List<Review> Reviews { get => reviews; set => reviews = value; }
        public Farmer Farmer { get => farmer; set => farmer = value; }
        public int Stock { get => stock; set => stock = value; }

        public  string GetUploadedImagePath()
        {
            //string filename = $"product-{DateTime.Now.Ticks}.jpg";

            //return Utilities.CopyImage(Image, filename); 

            return this.Image;
        }

        public void FetchReviews()
        {
            try
            {
                reviews.Clear();

                using (SqlConnection connection = new SqlConnection(Utilities.getConnectionString()))
                {
                    connection.Open();

                    string query = $"Select * from [Review] " +
                        $"WHERE Product = {this.id}";

                    SqlCommand cmd = new SqlCommand(query, connection);

                    using (SqlDataReader sqlData = cmd.ExecuteReader())
                    {
                        

                        while (sqlData.Read())
                        {
                            Review review = new Review();

                            review.Id = (int)sqlData["ID"];
                            review.Comment = sqlData["Comment"].ToString();
                            review.Rating = (int)sqlData["Rating"];
                            review.Customer = new Customer((int)sqlData["Customer"]);
                           
                            this.reviews.Add(review);
                        }

                        

                    }


                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

    }
}

