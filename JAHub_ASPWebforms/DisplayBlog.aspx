<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayBlog.aspx.cs" Inherits="JAHub_ASPWebforms.DisplayBlog" MasterPageFile="~/Site.Master"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <nav class="navbar navbar-default">
  <div class="container-fluid">
    <ul class="nav navbar-nav">
      <li class="active"><a href="Blog">AgriBlogs</a></li>
      <li><a href="CreateBlog">Create</a></li>
      <li><a href="MyBlogs">My Blogs</a></li>
    </ul>
  </div>
</nav>
    <div>
        <div class="container">
         <div class="jumbotron">
            <h1 runat="server" id="lblTitle">Blog Title</h1>
              <h4 runat="server" id="lblAuthor">Author:</h4>
              <h4 runat="server" id="lblPublishDate">Date Published:</h4>
              <h4 runat="server" id="lblDescription">Description:</h4>
          </div>
            </div>
        <div class="col-sm-8">
            <blockquote>
                <p runat="server" id="lblBlogBody">Some text in the body of the blog</p>
         </blockquote>
        </div>
    </div>
    <style>
        .container{
            padding: 0;
        }
        form{
            height:100%;
        }
        .col-sm-8{
            width:100%;
            height:fit-content
        }
         .row .content {
        height: 900px;
    }
         .jumbotron{
             background-color:lightseagreen;
             color: white;
         }
    </style>
</asp:Content>