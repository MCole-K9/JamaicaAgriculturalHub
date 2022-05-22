<%@ Page Title="Grants" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Grants.aspx.cs" Inherits="JAHub_ASPWebforms.Grants" %>

<%@ Register Src="~/Grant_Controls/USERCONTROL_GrantDDisplay.ascx" TagPrefix="uc1" TagName="USERCONTROL_GrantDDisplay" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <uc1:USERCONTROL_GrantDDisplay runat="server" ID="USERCONTROL_GrantDDisplay" />
    </div>
</asp:Content>
