<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminSelectUser.aspx.cs" Inherits="JAHub_ASPWebforms.Administration.AdminSelectUser" 
    MasterPageFile="~/Site.Master"%>

<asp:Content ContentPlaceHolderID="MainContent" runat="server" ID="AdmiSelectUser">
    <div class="row">
        <h3>Select User</h3>
    </div>

    <div class="row">
        <div class="form-group">
            <label for="#txtSearchBar" class="control-label col-sm-3">Search for User by Name: </label>
            <asp:TextBox runat="server" ID="txtSearchBar" CssClass="form-control col-sm-6 input-sm"></asp:TextBox>
            <asp:Button runat="server" ID="btnClearSearchBar" CssClass="btn btn-default input-sm col-sm-3" Text="Clear Search"/>
        </div>
    </div>

    <div class="row">
        <asp:GridView runat="server" ID="tblUsers" AutoGenerateColumns="False" CssClass="table table-striped"></asp:GridView>
    </div>
</asp:Content>