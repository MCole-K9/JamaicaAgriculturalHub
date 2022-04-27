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
                            review.Headline = sqlData["Headline"].ToString();
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

        public List<float> CalculateReviewPercentage()
        {
            try
            {
                int totalReviews = this.Reviews.Count;

                List<Review> Rating5Reviews = this.Reviews.Where(q => q.Rating == 5).ToList();
                List<Review> Rating4Reviews = this.Reviews.Where(q => q.Rating == 4).ToList();
                List<Review> Rating3Reviews = this.Reviews.Where(q => q.Rating == 3).ToList();
                List<Review> Rating2Reviews = this.Reviews.Where(q => q.Rating == 2).ToList();
                List<Review> Rating1Reviews = this.Reviews.Where(q => q.Rating == 1).ToList();


                float ratingCount5 = Rating5Reviews.Count();
                float ratingCount4 = Rating4Reviews.Count();
                float ratingCount3 = Rating3Reviews.Count();
                float ratingCount2 = Rating2Reviews.Count();
                float ratingCount1 = Rating1Reviews.Count();


                List<float> rating = new List<float>();
                float star5Percentage = (ratingCount5 / totalReviews) * 100;
                float star4Percentage = (ratingCount4 / totalReviews) * 100;
                float star3Percentage = (ratingCount3 / totalReviews) * 100;
                float star2Percentage = (ratingCount2 / totalReviews) * 100;
                float star1Percentage = (ratingCount1 / totalReviews) * 100;

                rating.Add(star5Percentage);
                rating.Add(star4Percentage);
                rating.Add(star3Percentage);
                rating.Add(star2Percentage);
                rating.Add(star1Percentage);

                return rating;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Product product &&
                   Id == product.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }
    }
}

