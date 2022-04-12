<%@ Page Language="C#" Title="My Blogs" AutoEventWireup="true" CodeBehind="MyBlogs.aspx.cs" Inherits="JAHub_ASPWebforms.MyBlogs" MasterPageFile="~/Site.Master"%>

    <asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
             <nav class="navbar navbar-default">
              <div class="container-fluid">
                <ul class="nav navbar-nav">
                  <li><a href="Blog">AgriBlogs</a></li>
                  <li><a href="CreateBlog">Create</a></li>
                  <li class="active"><a href="MyBlogs">My Blogs</a></li>
                </ul>
              </div>
            </nav>
        <div>
            <h1>MY BLOG</h1>
        </div>
    </asp:Content>
