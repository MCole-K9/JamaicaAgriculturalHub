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
            Blog blog = (Blog)Session["BlogData"];
            this.Title = blog.Title;
            lblTitle.Text = blog.Title;
            lblAuthor.Text += blog.GetAuthorName(blog.AuthorID);
            lblPublishDate.Text += blog.PublishDateString;
            lblDescription.Text += blog.Description;
            lblBlogBody.Text = blog.BlogBody;
        }
    }
}