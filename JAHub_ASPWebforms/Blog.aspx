<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Blog.aspx.cs" Inherits="JAHub_ASPWebforms.WebFrmBlog" MasterPageFile="~/Site.Master" Title="Blog"%>
<%@register src = "~/ucWebBlog.ascx" TagName="WebControl" TagPrefix="blogControl"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
    <nav class="navbar navbar-default">
  <div class="container-fluid">
    <ul class="nav navbar-nav">
      <li class="active"><a href="Blog">AgriBlogs</a></li>
      <li><a href="CreateBlog">Create</a></li>
      <li><a href="MyBlogs">My Blogs</a></li>
    </ul>
  </div>
</nav>
    <div class="container-fluid text-center">    
  <div class="row content">
    <div class="col-sm-8 text-left"> 
      <h1 id="h1AgriBlog">Agricultural Blogs</h1>
      <p class="AgriBlogDesc">Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>

                  <div class="input-group">
                    <input type="text" class="form-control" placeholder="Search" id="txtSearch"/>
                    <div class="input-group-btn">
                      <button class="btn btn-primary btnSearch" type="submit">
                        <span class="glyphicon glyphicon-search"></span>
                      </button>
                    </div>
                  </div>

            <div class="dropdown cboSort">
              <button class="btn btn-primary dropdown-toggle btnSort" type="button" data-toggle="dropdown">Sort Blogs
              <span class="caret"></span></button>
              <ul class="dropdown-menu">
                <li><a>Oldest</a></li>
                 <li><a>Newest</a></li>
                <li><a>Rating</a></li>
                <li><a>A-Z</a></li>
                <li><a>Z-A</a></li>
              </ul>
            </div>
        <div style="height:600px; margin-bottom: 50px;">
             <asp:Panel ID="pnlBlogContainer" runat="server" Height="100%" BorderStyle="Groove" CssClass="pnlBlogContainer">
        </asp:Panel>
        </div>
       
    </div>
  </div>
</div>
        </div>
    <style>
        form{
            height:100%;
        }
        .AgriBlogDesc{
            margin-bottom: 50px;
        }
        .pnlBlogContainer {
    margin-top: 20px;
    padding: 10px;
    overflow-y: scroll;
     
}
        .row .content {
        height: 1000px;
        margin:0;
        display : flex;
        justify-content: center;
    }
        .col-sm-8 {
            width:100%;
        }
        .cboSort{
            margin-left: calc(100% - 102px);
        }
        .btnSort{
            width: fit-content;
        }
        .btnSearch{
            width: fit-content;
        }
        .input-group{
            width: 300px;
            float:left;
        }
    </style>
</asp:Content>
