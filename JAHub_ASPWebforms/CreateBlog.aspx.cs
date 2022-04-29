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
            try
            {
                int id = (int)Session["UserID"];
            }catch(Exception)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "clickLoginNavBtn()", true);
            }
        }

        protected void btnPost_Click(object sender, EventArgs e)
        {
            if (txtBlogBody.Value == " " || txtDescription.Value == "" || txtTitle.Value == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertFunction", "alert(\"Fill Out All Feilds\")", true);
            }
            else
            {
                Blog blog = new Blog();
                string ParsedBlody = txtBlogBody.Value.Replace("'", "''");
                blog.CreateBlogPost((int)Session["UserId"], txtTitle.Value, txtDescription.Value, ParsedBlody);
                Response.Redirect("~/Blog.aspx");
            }
        }
    }
}