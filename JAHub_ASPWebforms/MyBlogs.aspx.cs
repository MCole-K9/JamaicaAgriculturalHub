using System;
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
            blogs = Util.DisplayBlogsToWeb($"EXEC SortBlogsOldestAuthor @Id = {3};");
            foreach (Blog blog in blogs)
            {
                IDinc++;
                ucWebBlog ucWeb = (ucWebBlog)Page.LoadControl("~/ucWebBlog.ascx");
                ucWeb.GetBlog(blog);
                ucWeb.ID = "BlogControl" + IDinc.ToString();
                pnlBlogContainer.Controls.Add(ucWeb);
            }
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Value != "")
            {
                pnlBlogContainer.Controls.Clear();
                int IDinc = 0;
                List<Blog> blogs = new List<Blog>();
                blogs = Util.DisplayBlogsToWeb($"SELECT * FROM [Blog] WHERE Title LIKE '%{txtSearch.Value}%' AND Author = {3}");
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

        protected void btnSortby_Click(object sender, EventArgs e)
        {
            if (selSort.Value != "")
            {
                pnlBlogContainer.Controls.Clear();
                int IDinc = 0;
                List<Blog> blogs = new List<Blog>();
                switch (selSort.Value)
                {
                    case "A-Z":
                        blogs = Util.DisplayBlogsToWeb($"EXEC SortBlogsAscendingAuthor @Id = {3}");
                        break;
                    case "Z-A":
                        blogs = Util.DisplayBlogsToWeb($"EXEC SortBlogsDescendingAuthor @Id = {3}");
                        break;
                    case "Rating":
                        blogs = Util.DisplayBlogsToWeb($"EXEC SortBlogsRatingWebAuthor @Id = {3}");
                        break;
                    case "Oldest":
                        blogs = Util.DisplayBlogsToWeb($"EXEC SortBlogsNewestAuthor @Id = {3}");
                        break;
                }
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
}