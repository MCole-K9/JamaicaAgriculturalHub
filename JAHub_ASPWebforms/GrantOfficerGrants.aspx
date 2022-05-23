<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GrantOfficerGrants.aspx.cs" Inherits="JAHub_ASPWebforms.GrantOfficerGrants" %>




<%@ Register src="Grant_Controls/USERCONTROL_GrantDDisplay.ascx" tagname="USERCONTROL_GrantDDisplay" tagprefix="uc1" %>
<%@ Register Src="~/Grant_Controls/USERCONTROL_GrantDDisplay.ascx" TagPrefix="uc2" TagName="USERCONTROL_GrantDDisplay" %>





<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%">
        <tr>
            <td colspan="2">
                <uc2:USERCONTROL_GrantDDisplay ID="USERCONTROL_GrantDDisplay1" runat="server" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>
