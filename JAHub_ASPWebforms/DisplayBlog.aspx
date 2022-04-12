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
 <div class="container-fluid text-center">    
  <div class="row content">
    <div class="col-sm-8 text-left"> 
        <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Title"></asp:Label>
        <br />
        <asp:Label ID="lblAuthor" runat="server" Text="Written by:" Font-Bold="True" Font-Italic="True"></asp:Label>
        <br />
        <asp:Label ID="lblPublishDate" runat="server" Text="Published:" Font-Bold="True" Font-Italic="True"></asp:Label>
        <br />
        <asp:Label ID="lblDescription" runat="server" Text="Description:" Font-Bold="True" Font-Italic="True"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblBlogBody" runat="server" Text="Body of the blog"></asp:Label>
        </div>
      </div>
     </div>
    <style>
        .col-sm-8{
            width:100%;
        }
    </style>
</asp:Content>