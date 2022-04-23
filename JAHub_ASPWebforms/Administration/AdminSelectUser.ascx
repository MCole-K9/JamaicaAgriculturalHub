<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AdminSelectUser.ascx.cs" Inherits="JAHub_ASPWebforms.Administration.AdminSelectUser1" %>

<div class="row">
    <h3>Select User</h3>
</div>

<div class="row">
    <asp:UpdatePanel runat="server" ID="udpSearcbar" UpdateMode="always">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="txtSearchBar" EventName="TextChanged" />
        </Triggers>
        <ContentTemplate>
            <div class="form-group">
            <label for="#txtSearchBar" class="control-label input-sm col-sm-3">Search for User by Name: </label>
            <asp:TextBox runat="server" ID="txtSearchBar" CssClass="form-control col-lg-1 input-sm" OnTextChanged="txtSearchBar_TextChanged" AutoPostBack="true"></asp:TextBox>
            <asp:Button runat="server" ID="btnClearSearchBar" CssClass="btn btn-default input-sm col-lg-1" Text="Clear Search" OnClick="btnClearSearchBar_Click"/>
        </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</div>

<div class="row">
    <asp:UpdatePanel runat="server" ID="udpTable" UpdateMode="always">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="txtSearchBar" EventName="TextChanged" />
        </Triggers>
        <ContentTemplate>
            <asp:GridView runat="server" ID="tblUsers" AutoGenerateColumns="False" CssClass="table table-striped" OnRowCommand="tblUsers_RowCommand">
            </asp:GridView>
        </ContentTemplate>
    </asp:UpdatePanel>
</div>