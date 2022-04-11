<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Blog.aspx.cs" Inherits="JAHub_ASPWebforms.WebFrmBlog" MasterPageFile="~/Site.Master" Title="Blog"%>
<%@register src = "~/ucWebBlog.ascx" TagName="WebControl" TagPrefix="blogControl"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <nav class="navbar navbar-default">
  <div class="container-fluid">
    <ul class="nav navbar-nav">
      <li class="active"><a href="#">AgriBlogs</a></li>
      <li><a href="#">Create</a></li>
      <li><a href="#">My Blogs</a></li>
    </ul>
  </div>
</nav>
    <div class="container-fluid text-center">    
  <div class="row content">
    <div class="col-sm-8 text-left"> 
      <h1 id="h1AgriBlog">Agricultural Blogs</h1>
      <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>
        <asp:Panel ID="Panel2" runat="server" Width="1440px">
            <asp:Label ID="lblSearch" runat="server" Text="Search"></asp:Label>
            <asp:TextBox ID="txtSearch" runat="server" Height="15px" Width="147px"></asp:TextBox>
            <asp:DropDownList ID="cboSort" runat="server">
                <asp:ListItem>Rating</asp:ListItem>
                <asp:ListItem>Latest</asp:ListItem>
            </asp:DropDownList>
        </asp:Panel>
        <asp:Panel ID="pnlBlogContainer" runat="server" Height="600px" BorderStyle="Solid" CssClass="pnlBlogContainer">
        </asp:Panel>
    </div>
  </div>
</div>
    <style>
        .pnlBlogContainer {
    margin-top: 20px;
    padding: 10px;
    overflow-y: scroll;
     
}
        .row.content {
        height: 100vh;
        margin:0;
        display : flex;
        justify-content: center;
    }
        .col-sm-8 {
            width:100%;
        }

    </style>
</asp:Content>
