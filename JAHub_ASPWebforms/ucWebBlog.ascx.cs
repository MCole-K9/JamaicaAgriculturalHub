using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using JAHubLib;

namespace JAHub_ASPWebforms
{
    public partial class ucWebBlog : System.Web.UI.UserControl
    {
        Blog b = new Blog();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        public void GetBlog(Blog blog)
        {
            b = blog;
            this.lblTitle.InnerHtml += blog.Title;
            this.lblAuthor.InnerHtml += blog.GetAuthorName(blog.AuthorID);
            this.lblDescription.InnerHtml += blog.Description;
            this.lblPublishedDate.InnerHtml += blog.PublishDateString;
        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            Session["BlogData"] = b;
            Response.Redirect("~/DisplayBlog.aspx");
        }
    }
}