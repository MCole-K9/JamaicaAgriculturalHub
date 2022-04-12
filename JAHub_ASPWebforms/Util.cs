using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using JAHubLib;

namespace JAHub_ASPWebforms
{
    public static class Util
    {
        public static string GetSolFilePath()
        {
            string path = HttpRuntime.AppDomainAppPath;
            return path.Substring(0, path.Length - 19);
        }
        public static string getConnectionString()
        {
            return "Data Source=jamaicaagriculturalhub.mssql.somee.com;Initial Catalog=jamaicaagriculturalhub;Persist Security Info=True;User ID=Ethan_Hughs_SQLLogin_1;Password=yq8mavdef8";
        }
        public static List<Blog> DisplayBlogsToWeb()
        {
            List<Blog> BlogLists = new List<Blog>();
            SqlConnection conn = new SqlConnection(Util.getConnectionString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("EXEC SortBlogsOldest", conn);
            SqlDataReader sqlData = cmd.ExecuteReader();
            
            while (sqlData.Read())
            {
                Blog blog = new Blog();
                blog.BlogID = (int)sqlData["ID"];
                blog.Title = sqlData["Title"].ToString();
                blog.AuthorID = (int)sqlData["Author"];
                blog.Description = sqlData["Description"].ToString();
                blog.BlogBody = sqlData["Body"].ToString();
                blog.PublishDateString = sqlData["PublishedDate"].ToString();
                blog.Rating = Convert.ToInt16(sqlData["Rating"]);
                BlogLists.Add(blog);
            }
            conn.Close();
            return BlogLists;
        }
    }
}