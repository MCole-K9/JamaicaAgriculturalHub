<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucWebBlog.ascx.cs" Inherits="JAHub_ASPWebforms.ucWebBlog" %>
<asp:Panel ID="pnlBlogControl" runat="server" BackColor="LightSeaGreen" BorderStyle="Outset" Height="100px" CssClass="pad">
    <asp:Button ID="btnView" runat="server" Text="View" CssClass="ViewButton" Width="62px" OnClick="btnView_Click" />
    <ul id="ulListWrapper">
  <li id="liTitle">Title: 
      <asp:Label ID="lblTitle" runat="server" Text="Label"></asp:Label>
        </li>
  <li id="liAuthor">Author: 
      <asp:Label ID="lblAuthor" runat="server" Text="Label"></asp:Label>
        </li>
  <li id="liPublishDate">Date Published: 
      <asp:Label ID="lblDatePublished" runat="server" Text="Label"></asp:Label>
        </li>
  <li id="liDescription">Description: 
      <asp:Label ID="lblDescription" runat="server" Text="Label"></asp:Label>
        </li>
</ul>
</asp:Panel>
<style>
    .pad{
        padding:10px;
        margin-bottom:5px;
        }
    ul{
        list-style: none;
    }
    .ViewButton{
      float:right;
        height: 26px;
    }
    .blog-text-wrapper{
        display:flex;
        flex-direction: column;
        justify-content: space-between;
    }
</style>
