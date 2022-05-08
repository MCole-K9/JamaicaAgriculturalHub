using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAHubLib;

namespace JAHub_ASPWebforms
{
    public partial class ProductDetail : System.Web.UI.Page
    {
        Product product;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.product = (Product)Session["ProductDetail"];
                this.product.FetchReviews();
                PopulateFields();
                LoadReviews();

                LoadRatingPercentage();
            }
           
        }
        private void PopulateFields()
        {
            imgProduct.Src = product.Image;
            lblProductName.InnerText = product.Name;
            lblProductPrice.InnerText = $"${product.Price} Per Lbs";
        }
        private void LoadReviews()
        {
            int index = 0;
            pnlReviews.Controls.Clear();

            if(product.Reviews.Count != 0)
            {
                foreach (var review in product.Reviews)
                {
                    Shop_Controls.UsrReview review1 = (Shop_Controls.UsrReview)Page.LoadControl("~/Shop_Controls/UsrReview.ascx");
                    review1.SetReview(review);
                    review1.SetIDSequence(index);
                    pnlReviews.Controls.Add(review1);
                    index++;
                }
                ZRMessage.Attributes.Add("style", "display: none");
            }
          
            
            
        }

        public void LoadRatingPercentage()
        {
            List<float> ratingPercentage = product.CalculateReviewPercentage();

            rating5.Attributes.Remove("style");
            rating5.Attributes.Add("style", $"width: {ratingPercentage[0]}% ;");
            rating5.Attributes.Add("aria-valuenow", $"{ratingPercentage[0]}");
            lblpercentage5.InnerText = (int)ratingPercentage[0] < 0 ? "0%" : $"{(int)ratingPercentage[0]}%";

            rating4.Attributes.Remove("style");
            rating4.Attributes.Add("style", $"width: {ratingPercentage[1]}% ;");
            rating4.Attributes.Add("aria-valuenow", $"{ratingPercentage[1]}");
            lblpercentage4.InnerText = (int)ratingPercentage[1] < 0 ? "0%" : $"{(int)ratingPercentage[1]}%";

            rating3.Attributes.Remove("style");
            rating3.Attributes.Add("style", $"width: {ratingPercentage[2]}% ;");
            rating3.Attributes.Add("aria-valuenow", $"{ratingPercentage[2]}");
            lblpercentage3.InnerText = (int)ratingPercentage[2] < 0 ? "0%" : $"{(int)ratingPercentage[2]}%";

            rating2.Attributes.Remove("style");
            rating2.Attributes.Add("style", $"width: {ratingPercentage[3]}% ;");
            rating2.Attributes.Add("aria-valuenow", $"{ratingPercentage[3]}");
            lblpercentage2.InnerText = (int)ratingPercentage[3] < 0 ? "0%" : $"{(int)ratingPercentage[3]}%";

            rating1.Attributes.Remove("style");
            rating1.Attributes.Add("style", $"width: {ratingPercentage[4]}% ;");
            rating1.Attributes.Add("aria-valuenow", $"{ratingPercentage[4]}");
            lblpercentage1.InnerText = (int)ratingPercentage[4] < 0 ? "0%" : $"{(int)ratingPercentage[4]}%";

        }

        protected void btnReviewSubmit_Click(object sender, EventArgs e)
        {
            if(Session["UserId"] != null)
            {
                Customer customer = new Customer(true);
                this.product = (Product)Session["ProductDetail"];
                Review newReview = new Review
                {
                    Headline = headline.Value,
                    Comment = comment.Value,
                   Rating = int.Parse(hidRating.Value),
                   ProductID  = this.product.Id,

                };

                

                customer.AddReview(newReview);
                Response.Redirect(Request.RawUrl);
            }
            else
            {
 
                Page.ClientScript.RegisterStartupScript(this.GetType(), "clickLoginNavBtn", "clickLoginNavBtn()", true);
            }
            
        }
    }
}