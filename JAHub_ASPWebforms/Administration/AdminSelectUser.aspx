<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminSelectUser.aspx.cs" Inherits="JAHub_ASPWebforms.Administration.AdminSelectUser" 
    MasterPageFile="~/Site.Master"%>

<asp:Content ContentPlaceHolderID="MainContent" runat="server" ID="AdmiSelectUser">
    <div>
        <h3>Select User</h3>
    </div>

    <div>
        <label for="#txtSearchBar">Search for User by Name: </label>
        <asp:TextBox runat="server" ID="txtSearchBar" CssClass=""></asp:TextBox>
        <asp:Button runat="server" ID="btnClearSearchBar" />
    </div>

    <div><asp:GridView runat="server" ID="tblUsers" AutoGenerateColumns="False"></asp:GridView></div>
</asp:Content>