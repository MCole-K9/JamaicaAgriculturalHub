<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AdminViewModeration.ascx.cs" Inherits="JAHub_ASPWebforms.Administration.AdminViewModeration" EnableViewState="True" ViewStateMode="Enabled" %>

<%@ Register TagPrefix="uc" TagName="AddInfraction" Src="~/Administration/usrAddInfraction.ascx" %>

<div class="row">
    <h2>View Infractions for user <%= Name %> (ID: <%= UserId %>)</h2>
</div>

<div>
    <asp:Repeater runat="server" ID="rptUserInfractions" DataSourceID="dsInfractions">
        <ItemTemplate>
            <uc:AddInfraction runat="server" ID="admUserInfraction" />
        </ItemTemplate>
    </asp:Repeater>
    <asp:PlaceHolder runat="server" ID="phUserInfractions" />
</div>

<asp:SqlDataSource runat="server" ID="dsInfractions" SelectCommand="SELECT [ID], [TimeStamp], [Admin], [Reason] FROM [Infraction];" 
    ConnectionString="Data Source=jamaicaagriculturalhub.mssql.somee.com;Initial Catalog=jamaicaagriculturalhub;Persist Security Info=True;User ID=Ethan_Hughs_SQLLogin_1;Password=yq8mavdef8"  />


<div class="row">
    <asp:Button runat="server" ID="btnAddInfraction" CssClass="btn btn-default input-sm col-lg-2" Text="Add Infraction" OnClick="btnAddInfraction_Click"/>
</div>
