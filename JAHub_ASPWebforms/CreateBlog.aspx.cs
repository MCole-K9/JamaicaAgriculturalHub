using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAHubLib;

namespace JAHub_ASPWebforms
{
    public partial class CreateBlog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnPost_Click(object sender, EventArgs e)
        {
            Blog blog = new Blog();
            string ParsedBlody = txtBlogBody.Value.Replace("'","''");
            blog.CreateBlogPost(3, txtTitle.Value, txtDescription.Value, ParsedBlody);
            
        }
    }
}