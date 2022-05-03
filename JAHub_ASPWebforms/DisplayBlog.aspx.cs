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
            Blog blog = new Blog();
            if (!IsPostBack)
            {
                try
                {
                    blog = (Blog)Session["BlogData"];
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
                blog = (Blog)Session["BlogData"];
                this.Title = blog.Title;
            }
            try
            {
                int id = (int)Session["UserId"];
                if (blog.AuthorID == id)
                {
                    btnDeleteBlog.Visible = true;
                    btnEditBlog.Visible = true;
                }
            }
            catch (NullReferenceException) { }
            
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

        protected void btnDeleteBlog_Click(object sender, EventArgs e)
        {
            Blog displayedBlog = (Blog)Session["BlogData"];
            SqlConnection connection = new SqlConnection(Utilities.getConnectionString());
            connection.Open();
            SqlCommand cmd = new SqlCommand($"DELETE FROM Blog WHERE ID = {displayedBlog.BlogID}", connection);
            cmd.ExecuteNonQuery();
            Response.Redirect("~/MyBlogs.aspx");
        }

        protected void btnEditBlog_Click(object sender, EventArgs e)
        {
            Blog displayedBlog = (Blog)Session["BlogData"];
            Session["BlogForEdit"] = displayedBlog;
            Response.Redirect("~/CreateBlog.aspx");
        }
    }
}