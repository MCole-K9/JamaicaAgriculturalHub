<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="usrIndustryBlock.ascx.cs" Inherits="JAHub_ASPWebforms.Verification.usrIndustryBlock" %>

<div class="row col-1g-5">
    <h4>Industry-Related Information</h4>
    <div class="row">
        <p>Number of Employees</p><asp:TextBox runat="server" ID="txtNumberOfEmployees" CssClass="col-lg-3 input-sm"></asp:TextBox>
        <asp:CustomValidator ID="cusNumberOfEmployees" runat="server" ControlToValidate="txtNumberOfEmployees"
            OnServerValidate="cusNumberOfEmployees_ServerValidate" Text="" CssClass=" text col-lg-3 text-danger input-sm" />
    </div>
    <div class="row">
        <asp:Label runat="server" ID="lblHeavyMachinery" CssClass="col-lg-3 input-sm">
            Do you use heavy machinery such as tractors, processors, or other forms of powered equipment?*
        </asp:Label>
        <div class="row">
            <asp:RadioButton ID="rdoIndustryYes" runat="server" ValidationGroup="radioButtons" CssClass="col-lg-2 input-sm" Text="Yes"/>
            <asp:RadioButton ID="rdoIndustryNo" runat="server" ValidationGroup="radioButtons" CssClass="col-lg-2 input-sm" Text="No"/>
            <div>
                <asp:CustomValidator ID="cusRadioButtons" runat="server" ValidationGroup="radioButtons"
                    ErrorMesage="You must select one option or another" OnServerValidate="cusRadioButtons_ServerValidate"
                    CssClass="col-lg-3 input-sm text text-danger"/>
            </div>
        </div>
    </div>
</div>