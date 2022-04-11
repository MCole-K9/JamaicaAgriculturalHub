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
            SqlConnection conn = new SqlConnection(Utilities.getConnectionString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * FROM [Blog]", conn);
            SqlDataReader sqlData = cmd.ExecuteReader();
            int IDinc = 0;
            while (sqlData.Read())
            {
                IDinc++;
                Blog blog = new Blog();

                blog.BlogID = (int)sqlData["ID"];
                blog.Title = sqlData["Title"].ToString();
                blog.AuthorID = (int)sqlData["Author"];
                blog.Description = sqlData["Description"].ToString();
                blog.BlogBody = sqlData["Body"].ToString();
                blog.PublishDateString = sqlData["PublishedDate"].ToString();
                blog.Rating = Convert.ToInt16(sqlData["Rating"]);
                ucWebBlog ucWeb = (ucWebBlog)Page.LoadControl("~/ucWebBlog.ascx");
                ucWeb.GetBlog(blog);
                ucWeb.ID = "BlogControl" + IDinc.ToString();
                pnlBlogContainer.Controls.Add(ucWeb);

            }
            conn.Close();
		}
		
    }
}