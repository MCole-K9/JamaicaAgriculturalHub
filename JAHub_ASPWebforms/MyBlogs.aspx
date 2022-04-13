<%@ Page Language="C#" Title="My Blogs" AutoEventWireup="true" CodeBehind="MyBlogs.aspx.cs" Inherits="JAHub_ASPWebforms.MyBlogs" MasterPageFile="~/Site.Master"%>

    <asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
              <div class="row">
    <nav class="navbar navbar-default">
  <div class="container-fluid">
    <ul class="nav navbar-nav">
       <li><a href="Blog">AgriBlogs</a></li>
      <li><a href="CreateBlog">Create</a></li>
      <li class="active"><a href="MyBlogs">My Blogs</a></li>
    </ul>
  </div>
</nav>
    <div class="container-fluid text-center">    
  <div class="row content">
    <div class="col-sm-8 text-left"> 
      <h1 id="h1AgriBlog">Your Blogs</h1>
      <p class="AgriBlogDesc">Here you can view all the Blogs you have posted to our Website</p>

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
        height: 850px;
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
        .well{
        background-color: #f5f5f5;
        box-shadow: 0 0 10px 1px rgba(0,0,0,0.4);
    }
    </style>
    </asp:Content>
