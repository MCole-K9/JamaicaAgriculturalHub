<%@ Page Title="Grants" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Grants.aspx.cs" Inherits="JAHub_ASPWebforms.Grants" %>

<%@ Register Src="~/GrantDisplay_Controls/ucGeneralGrantInfo.ascx" TagPrefix="uc1" TagName="ucGeneralGrantInfo" %>







<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <uc1:ucGeneralGrantInfo runat="server" ID="ucGeneralGrantInfo" />
    </div>
</asp:Content>
