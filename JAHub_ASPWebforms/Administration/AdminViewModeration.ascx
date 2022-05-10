<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AdminViewModeration.ascx.cs" Inherits="JAHub_ASPWebforms.Administration.AdminViewModeration" EnableViewState="True" ViewStateMode="Enabled" %>

<%@ Register TagPrefix="uc" TagName="AddInfraction" Src="~/Administration/usrAddInfraction.ascx" %>

<%@ Register TagPrefix="uc" TagName="InfractionItem" Src="~/Administration/usrInfractionItem.ascx" %>

<div class="row">
    <h2>View Infractions for user <%= Name %> (ID: <%= UserId %>)</h2>
</div>

<div class="row">
    
    <div class="row">
        <asp:UpdatePanel runat="server" ID="udpInfractions" UpdateMode="Always">
            <ContentTemplate>
                <asp:Repeater runat="server" ID="rptUserInfractions" DataSourceID="dsInfractions" OnItemDataBound="rptUserInfractions_ItemDataBound">
                    <ItemTemplate>
                        <uc:InfractionItem runat="server" ID="admUserInfraction" />
                    </ItemTemplate>
                    <SeparatorTemplate></br></SeparatorTemplate>
                </asp:Repeater>
            </ContentTemplate>
        </asp:UpdatePanel>
        
    </div>
    <div class="row">
        <asp:UpdatePanel runat="server" ID="udpAddInfractions" UpdateMode="Always">
            <ContentTemplate>
                <asp:Label runat="server" ID="lblNoInfractions" Visible="false"><%= this.Name %> has no Infractions</asp:Label>
                <asp:PlaceHolder runat="server" ID="phUserInfractions" />
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</div>

<asp:SqlDataSource runat="server" ID="dsInfractions" SelectCommand="SELECT [ID], [TimeStamp], [Admin], [Reason] FROM [Infraction];" 
    ConnectionString="Data Source=jamaicaagriculturalhub.mssql.somee.com;Initial Catalog=jamaicaagriculturalhub;Persist Security Info=True;User ID=Ethan_Hughs_SQLLogin_1;Password=yq8mavdef8">
    <SelectParameters></SelectParameters>
</asp:SqlDataSource>


<div class="row">
    <asp:Button runat="server" ID="btnAddInfraction" CssClass="btn btn-default input-sm col-lg-2" Text="Add Infraction" OnClick="btnAddInfraction_Click"/>
</div>
