﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAHubLib;

namespace JAHub_ASPWebforms
{
    public partial class MyBlogs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int IDinc = 0;
            List<Blog> blogs = new List<Blog>();
            blogs = Util.DisplayBlogsToWeb($"SELECT * FROM Blog WHERE Author = {3};");
            foreach (Blog blog in blogs)
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