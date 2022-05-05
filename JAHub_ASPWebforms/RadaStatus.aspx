<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RadaStatus.aspx.cs" Inherits="JAHub_ASPWebforms.RadaStatus" 
    MasterPageFile="~/Site.Master"%>

<!DOCTYPE html>

<asp:Content runat="server" ContentPlaceHolderID="MainContent" ID="RadaStatus">
    <div>
        <div class="row">
            <h2><asp:Label runat="server" ID="lblStatusHeading">Explanation</asp:Label></h2>
        </div>

        <div class="row">
            <asp:Label runat="server" ID="lblStatusExplanation">Explanation</asp:Label>  
        </div>

        <div class="row">
            <asp:Button runat="server" ID="btnRegisterOrViewInformation" Visible="false" />
        </div>
    </div>

</asp:Content>
        
