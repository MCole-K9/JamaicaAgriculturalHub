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
	public partial class WebFrmBlog : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            int IDinc = 0;
            List<Blog> blogs = new List<Blog>();
            blogs = Util.DisplayBlogsToWeb();
            foreach(Blog blog in blogs)
            {
                IDinc++;
                ucWebBlog ucWeb = (ucWebBlog)Page.LoadControl("~/ucWebBlog.ascx");
                ucWeb.GetBlog(blog);
                ucWeb.ID = "BlogControl" + IDinc.ToString();
                pnlBlogContainer.Controls.Add(ucWeb);
            }
           
        }

		
    }
}