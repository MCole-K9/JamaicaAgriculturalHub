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
            blogs = Util.DisplayBlogsToWeb("EXEC SortBlogsOldest");
            foreach(Blog blog in blogs)
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
            if(txtSearch.Value != "")
            {
                pnlBlogContainer.Controls.Clear();
                int IDinc = 0;
                List<Blog> blogs = new List<Blog>();
                blogs = Util.DisplayBlogsToWeb($"SELECT * FROM [Blog] WHERE Title LIKE '%{txtSearch.Value}%'");
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

        protected void dropDownSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropDownSort.SelectedValue != "")
            {
                pnlBlogContainer.Controls.Clear();
                int IDinc = 0;
                List<Blog> blogs = new List<Blog>();
                switch (dropDownSort.SelectedValue)
                {
                    case "A-Z":
                        blogs = Util.DisplayBlogsToWeb("EXEC SortBlogsAscending");
                        break;
                    case "Z-A":
                        blogs = Util.DisplayBlogsToWeb("EXEC SortBlogsDescending");
                        break;
                    case "Rating":
                        blogs = Util.DisplayBlogsToWeb("EXEC SortBlogsRatingWeb");
                        break;
                    case "Oldest":
                        blogs = Util.DisplayBlogsToWeb("EXEC SortBlogsNewest");
                        break;
                    default:
                        blogs = Util.DisplayBlogsToWeb("EXEC SortBlogsOldest");
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