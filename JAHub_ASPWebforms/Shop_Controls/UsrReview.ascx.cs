using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAHubLib;

namespace JAHub_ASPWebforms.Shop_Controls
{
    public partial class UsrReview : System.Web.UI.UserControl
    {
        private Review review;
        private int IDSequenece;

        public void SetReview(Review review)
        {
            this.review = review;
        }
        public void SetIDSequence(int id)
        {
            this.IDSequenece = id;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateReview();

            Name.ID += IDSequenece;
            Rating.ID += IDSequenece;
            Headline.ID += IDSequenece;
            Comment.ID += IDSequenece;

        }
        private void PopulateReview()
        {
            Name.InnerText = $"{ review.Customer.FirstName} {review.Customer.LastName}";
            Rating.InnerText = review.Rating.ToString();
            Headline.InnerText = review.Headline;
            Comment.InnerText = review.Comment;

        }
    }
}