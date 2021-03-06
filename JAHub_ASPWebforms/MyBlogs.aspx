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

        <div class="container">
          <div class="jumbotron">
            <h1 runat="server" id="lblTitle">Your Blogs</h1>
              <p class="AgriBlogDesc">Here you can view all the Blogs you have posted to our Website</p>
          </div>
        </div>

        <div class="SortSearchWrap">
            <div class="input-group">
                    <input type="text" class="form-control" placeholder="Search" id="txtSearch" runat="server"/>
                    <div class="input-group-btn">
                      <asp:button runat="server" class="btn btn-primary btnSearch" type="submit" ID="btnSearch" OnClick="btnSearch_Click" Text="Search">
                      </asp:button>
                    </div>
                  </div>

            <div class="input-group cboSort" style="width:fit-content">
                <asp:button runat="server" class="btn btn-primary btnSort" type="submit" ID="btnSortby" OnClick="btnSortby_Click" Text="Sort by:"></asp:button>
                    <select runat="server" class="form-control" id="selSort" style="width:150px;">
                        <option value="" disabled selected>Select an option</option>
                        <option>Oldest</option>
                        <option>Rating</option>
                        <option>A-Z</option>
                        <option>Z-A</option>
                    </select>
            </div>
        </div>

        <div style="height:600px; margin-bottom: 50px;">
             <asp:Panel ID="pnlBlogContainer" runat="server" Height="100%" BorderStyle="Groove" CssClass="pnlBlogContainer">
        </asp:Panel>
        </div>
       
        <style>
            .container{
                padding: 0;
            }
            .SortSearchWrap{
                display: inline-flex;
                justify-content: space-between;
                width:100%;
            }
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
            .content {
                height: 850px;
                margin:0;
                display : flex;
                justify-content: center;
            }
            .col-sm-8 {
                width:100%;
            }
            .cboSort{
                display: inline-flex;
                justify-content:space-between;
            }
            .btnSort{
                border-top-right-radius: 0px;
                border-bottom-right-radius: 0px;
            }
            .btnSearch ,.btnSort{
                width: fit-content;
            }
            .input-group{
                width: 300px;
            }
            .jumbotron{
                background-image: url(Resources/grapes.jpg);
                background-color: rgba(255,255,255,0.5);
                background-blend-mode: lighten;
            }
        </style>
   
    </asp:Content>
