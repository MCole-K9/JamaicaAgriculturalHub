using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAHubLib;

namespace JAHub_ASPWebforms
{
    public partial class DisplayBlog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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
    }
}