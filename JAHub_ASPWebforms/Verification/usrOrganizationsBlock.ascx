<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="usrOrganizationsBlock.ascx.cs" Inherits="JAHub_ASPWebforms.Verification.usrOrganizationsBlock" %>

<div class="row">
    <h4>Organizations</h4>
    <p class="row">Please list any relevant Organizations or Commodity Boards you may be a part of, 
        (for example: The Coffee Growers Association). 
        If you are not a part of any organization, leave this field blank</p>
    <div class="row">
        <asp:PlaceHolder ID="phOrganizatons" runat="server">
            <asp:TextBox ID="txtOrganizations" runat="server" CssClass="col-lg-3 input-sm"/>
        </asp:PlaceHolder>
    </div>

    <div class="row">
        <asp:Button ID="btnAddAnotherOrganization" runat="server" Text="Add Another Organization" 
            CssClass="btn btn-default col-lg-2 input-sm" OnClick="btnAddAnotherOrganization_Click"/>
        <asp:Button ID="btnRemoveOrganization" runat="server" Text="Remove Last Organization" 
            CssClass="btn btn-default invisible col-lg-2 input-sm" OnClick="btnRemoveOrganization_Click"/>
    </div>
</div>