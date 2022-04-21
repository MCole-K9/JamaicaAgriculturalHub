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
            try
            {
                List<Blog> blogs = new List<Blog>();
                blogs = Util.DisplayBlogsToWeb($"EXEC SortBlogsOldestAuthor @Id = {(int)Session["UserId"]};");
                foreach (Blog blog in blogs)
                {
                    IDinc++;
                    ucWebBlog ucWeb = (ucWebBlog)Page.LoadControl("~/ucWebBlog.ascx");
                    ucWeb.GetBlog(blog);
                    ucWeb.ID = "BlogControl" + IDinc.ToString();
                    pnlBlogContainer.Controls.Add(ucWeb);
                }
            }catch(Exception)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "clickLoginNavBtn()", true);
            }
            
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Value != "")
            {
                pnlBlogContainer.Controls.Clear();
                int IDinc = 0;
                List<Blog> blogs = new List<Blog>();
                blogs = Util.DisplayBlogsToWeb($"SELECT * FROM [Blog] WHERE Title LIKE '%{txtSearch.Value}%' AND Author = {(int)Session["UserId"]}");
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
                        blogs = Util.DisplayBlogsToWeb($"EXEC SortBlogsAscendingAuthor @Id = {(int)Session["UserId"]}");
                        break;
                    case "Z-A":
                        blogs = Util.DisplayBlogsToWeb($"EXEC SortBlogsDescendingAuthor @Id = {(int)Session["UserId"]}");
                        break;
                    case "Rating":
                        blogs = Util.DisplayBlogsToWeb($"EXEC SortBlogsRatingWebAuthor @Id = {(int)Session["UserId"]}");
                        break;
                    case "Oldest":
                        blogs = Util.DisplayBlogsToWeb($"EXEC SortBlogsNewestAuthor @Id = {(int)Session["UserId"]}");
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