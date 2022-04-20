<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="usrOrganizationsBlock.ascx.cs" Inherits="JAHub_ASPWebforms.Verification.usrOrganizationsBlock" %>

<div>
    <p>Please list any relevant Organizations or Commodity Boards you may be a part of, 
        (for example: The Coffee Growers Association). 
        If you are not a part of any organization, leave this field blank</p>
    <asp:PlaceHolder ID="phOrganizatons" runat="server">
        <asp:TextBox ID="txtOrganizations" runat="server"></asp:TextBox>
    </asp:PlaceHolder>

    <div Style="flex-direction:column; flex-wrap:nowrap; height: 86px; width: 530px;">
        <asp:Button ID="btnAddAnotherOrganization" runat="server" Text="Add Another Organization" 
            CssClass="btn btn-default" OnClick="btnAddAnotherOrganization_Click"/>
        <asp:Button ID="btnRemoveOrganization" runat="server" Text="Remove Last Organization" 
            CssClass="btn btn-default invisible" OnClick="btnRemoveOrganization_Click"/>
    </div>
</div>