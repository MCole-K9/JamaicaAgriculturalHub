<%@ Page Language="C#" AutoEventWireup="true" Title="Create" CodeBehind="CreateBlog.aspx.cs" Inherits="JAHub_ASPWebforms.CreateBlog" MasterPageFile="~/Site.Master"%>

    <asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
             <nav class="navbar navbar-default">
              <div class="container-fluid">
                <ul class="nav navbar-nav">
                  <li><a href="Blog">AgriBlogs</a></li>
                  <li class="active"><a href="CreateBlog">Create</a></li>
                  <li><a href="MyBlogs">My Blogs</a></li>
                </ul>
              </div>
            </nav>
        <div>
            <div class="container">
              <div class="jumbotron">
                <h1>Create a Blog</h1>
                <p><b>Help us help farmers and users alike by contributing agricultural knowledge and expertise. Using this page you can create a blog to share insightful information</b></p>
              </div>
            </div>

              <div class="form-group">
                <h4><label for="title">Title:</label></h4>
                <input type="text" class="form-control" id="txtTitle" runat="server">
              </div>
              <div class="form-group">
                <h4><label for="description">Description:</label></h4>
                <input type="text" class="form-control" id="txtDescription" runat="server">
              </div>
            <div class="form-group">
                <h4><label for="blogbody" class="lblBody">Body:</label></h4>
                <textArea class="form-control" id="txtBlogBody" style="height:500px;" runat="server"> </textArea>
              </div>
            <asp:button type="button" class="btn btn-primary btnPost" runat="server" id="btnPost" OnClick="btnPost_Click" Text="Post"></asp:button>
              
        </div>
        <style>
            .container{
                padding: 0;
            }
            input[type="text"]{
                max-width: 100%;
            }
            .lblBody
            {
                margin-top: 50px;
            }
            .btnPost{
                width: 75px;
                height: 34px;
                margin-left: calc(100% - 75px);
            }
            .jumbotron{
                background-image: url(Resources/grapes.jpg);
                background-color: rgba(255,255,255,0.5);
                background-blend-mode: lighten;
            }
        </style>








    </asp:Content>
