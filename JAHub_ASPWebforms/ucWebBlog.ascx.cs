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
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        public void GetBlog(Blog blog)
        {
            this.lblTitle.Text = blog.Title;
            this.lblAuthor.Text = blog.GetAuthorName(blog.AuthorID);
            this.lblDescription.Text = blog.Description;
            this.lblDatePublished.Text = blog.PublishDateString;
        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            Console.WriteLine("uhhh");
        }
    }
}