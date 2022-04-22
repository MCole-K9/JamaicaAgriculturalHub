<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminSelectUser.aspx.cs" Inherits="JAHub_ASPWebforms.Administration.AdminSelectUser" 
    MasterPageFile="~/Site.Master"%>

<asp:Content ContentPlaceHolderID="MainContent" runat="server" ID="AdmiSelectUser">
    <div class="row">
        <h3>Select User</h3>
    </div>

    <div class="row">
        <div class="form-group">
            <label for="#txtSearchBar" class="control-label input-sm col-sm-3">Search for User by Name: </label>
            <asp:TextBox runat="server" ID="txtSearchBar" CssClass="form-control col-lg-1 input-sm" OnTextChanged="txtSearchBar_TextChanged"></asp:TextBox>
            <asp:Button runat="server" ID="btnClearSearchBar" CssClass="btn btn-default input-sm col-lg-1" Text="Clear Search" OnClick="btnClearSearchBar_Click"/>
        </div>
    </div>

    <div class="row">
        <asp:UpdatePanel runat="server" ID="udpTable">
            <ContentTemplate>

            </ContentTemplate>
        </asp:UpdatePanel>
                <!-- I can try doing this declaratively-->

        <asp:GridView runat="server" ID="tblUsers" AutoGenerateColumns="False" CssClass="table table-striped" OnRowCommand="tblUsers_RowCommand">
            <Columns>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>