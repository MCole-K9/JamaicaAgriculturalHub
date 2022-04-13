<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucWebBlog.ascx.cs" Inherits="JAHub_ASPWebforms.ucWebBlog" %>
<%--<asp:Panel ID="pnlBlogControl" runat="server" BackColor="LightSeaGreen" BorderStyle="Outset" Height="100px" CssClass="pad">
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
</asp:Panel>--%>
<div class="well well-lg Blog">
    <div>
        <h5 runat="server" id="lblTitle"><b>Title:</b></h5>
        <h5 runat="server" id="lblAuthor"><b>Author:</b></h5>
        <h5 runat="server" id="lblPublishedDate"><b>Date Published:</b></h5>
        <h5 runat="server" id="lblDescription"><b>Description:</b></h5>
    </div>
    <asp:button type="button" class="btn btn-primary btnView" runat="server" id="btnView" OnClick="btnView_Click" Text="View"></asp:button>
</div>
<style>
    .btnView
    {
         width: 75px;
         height: 34px;
    }
    .Blog{
        display: flex;
        justify-content:space-between;
        align-items: start;
    }
    p{
        margin:0;
    }
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
