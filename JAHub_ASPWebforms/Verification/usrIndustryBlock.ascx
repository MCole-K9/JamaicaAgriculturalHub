<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="usrIndustryBlock.ascx.cs" Inherits="JAHub_ASPWebforms.Verification.usrIndustryBlock" %>

<div>
    <div>
        <div>
            <p>Number of Employees</p><asp:TextBox runat="server" ID="txtNumberOfEmployees"></asp:TextBox>
            <asp:CustomValidator ID="cusNumberOfEmployees" runat="server" ControlToValidate="txtNumberOfEmployees"
                OnServerValidate="cusNumberOfEmployees_ServerValidate" Text="" CssClass="text-danger"></asp:CustomValidator>
        </div>
    </div>
    <div>
        <asp:Label runat="server" ID="lblHeavyMachinery">
            Do you use heavy machinery such as tractors, processors, or other forms of powered equipment?*
        </asp:Label>
        <div>
            <asp:RadioButton ID="rdoIndustryYes" runat="server" />
            <asp:RadioButton ID="rdoIndustryNo" runat="server" />
        </div>
    </div>

</div>