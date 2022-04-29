using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAHubLib;
using System.Data.SqlClient;

namespace JAHub_ASPWebforms
{
    public partial class DisplayBlog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    Blog blog = (Blog)Session["BlogData"];
                    this.Title = blog.Title;
                    lblTitle.InnerHtml = blog.Title;
                    lblAuthor.InnerHtml += blog.GetAuthorName(blog.AuthorID);
                    lblPublishDate.InnerHtml += blog.PublishDateString;
                    lblDescription.InnerHtml += blog.Description;
                    lblBlogBody.InnerHtml = blog.BlogBody;
                }
                catch (NullReferenceException)
                {
                    Response.Redirect("~/Default.aspx");
                }
            }
            else
            {
                Blog blog = (Blog)Session["BlogData"];
                this.Title = blog.Title;
            }
        }
        public void RatingUp(object sender, EventArgs e)
        {
            Blog displayedBlog = (Blog)Session["BlogData"];
            displayedBlog.Rating++;
            SqlConnection connection = new SqlConnection(Utilities.getConnectionString());
            connection.Open();
            SqlCommand cmd = new SqlCommand($"UPDATE Blog SET Rating = {displayedBlog.Rating} WHERE ID = {displayedBlog.BlogID}", connection);
            cmd.ExecuteNonQuery();
        }
        public void RatingDown(object sender, EventArgs e)
        {
            Blog displayedBlog = (Blog)Session["BlogData"];
            if (displayedBlog.Rating > 0)
            {
                displayedBlog.Rating--;
                SqlConnection connection = new SqlConnection(Utilities.getConnectionString());
                connection.Open();
                SqlCommand cmd = new SqlCommand($"UPDATE Blog SET Rating = {displayedBlog.Rating} WHERE ID = {displayedBlog.BlogID}", connection);
                cmd.ExecuteNonQuery();
            }
        }
    }
}