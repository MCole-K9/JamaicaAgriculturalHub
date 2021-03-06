using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAHubLib;

namespace JAHub_ASPWebforms
{
    public partial class EditBlog : System.Web.UI.Page
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
            if(Session["BlogForEdit"] != null)
            {
                if (!IsPostBack)
                {
                    Blog b = (Blog)Session["BlogForEdit"];
                    txtBlogBody.Value = b.BlogBody;
                    txtDescription.Value = b.Description;
                    txtTitle.Value = b.Title;
                }
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
                if (Session["BlogForEdit"] != null)
                {
                    Blog b = (Blog)Session["BlogForEdit"];
                    
                    b.BlogBody = ParsedBody;
                    b.Description = txtDescription.Value;
                    b.Title = txtTitle.Value;
                    try
                    {
                        b.UpdateBlogPost(b);
                        Session.Remove("BlogForEdit");
                        Response.Redirect("~/MyBlogs.aspx");
                    }
                    catch (Exception ex)
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "alertFunction", $"alert(\"{ex.Message}\")", true);
                    }
                }
            }
        }
    }
}