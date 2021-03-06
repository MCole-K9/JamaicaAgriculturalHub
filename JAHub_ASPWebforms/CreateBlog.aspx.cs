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
            string ParsedBody = txtBlogBody.Value.Replace("'", "''");
            if (ParsedBody == "" || txtDescription.Value == "" || txtTitle.Value == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alertFunction", "alert(\"Fill Out All Feilds\")", true);
            }
            else
            {
                    try
                    {
                        Blog newBlog = new Blog();
                        newBlog.CreateBlogPost((int)Session["UserId"], txtTitle.Value, txtDescription.Value, ParsedBody);
                        Response.Redirect("~/Blog.aspx");
                    }
                    catch (Exception ex)
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertFunction", $"alert(\"{ex.Message}\")", true);
                    }
            }
        }
    }
}