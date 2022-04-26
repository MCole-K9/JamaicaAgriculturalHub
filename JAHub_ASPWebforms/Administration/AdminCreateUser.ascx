<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AdminCreateUser.ascx.cs" Inherits="JAHub_ASPWebforms.Administration.AdminCreateUser" EnableViewState="False" %>

<%@ Register Src="~/Verification/usrNameBlock.ascx" TagName="NameBlock" TagPrefix="uc"%>

<div>
    <h2>Create New User</h2>
    <p>Fields marked with '*' are Mandatory</p>
</div>

<div>
    <div class="row">
        <asp:DropDownList runat="server" ID="ddlUserRole" CssClass="btn btn-default input-sm col-lg-2"></asp:DropDownList>
    </div>
    <div>
        <uc:NameBlock ID="nbNewUserName" runat="server" />
    </div>
    <div class="row">
        <div>
            <asp:Label runat="server" ID="lblEmail" EnableViewState="False">Email: </asp:Label>
            <asp:TextBox runat="server" ID="txtEmail" EnableViewState="False"></asp:TextBox>
            <asp:RegularExpressionValidator runat="server" ErrorMessage="Must be a Valid Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                ControlToValidate="txtEmail" EnableViewState="False"></asp:RegularExpressionValidator>
        </div>
    </div>
    <div class="row">
        <asp:CheckBox runat="server" ID="chkShowPassword" Text="Show Password:" TextAlign="Left" CssClass="col-lg-2 input-sm" 
            OnCheckedChanged="chkShowPassword_CheckedChanged" AutoPostBack="True" CausesValidation="False" EnableViewState="False" />
    </div>
    
    <asp:UpdatePanel runat="server" ID="udpPassword" >
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="chkShowPassword" EventName="CheckedChanged" />
        </Triggers>
        <ContentTemplate>
            <div class="row">
                <div class="form-group">
                    <asp:Label runat="server" CssClass="form-label" EnableViewState="False">Password: </asp:Label>
                    <asp:TextBox runat="server" ID="txtPasswordOnce" CssClass="" TextMode="Password" EnableViewState="False"></asp:TextBox>
                    <asp:CustomValidator ID="cusPasswordOnce" runat="server" ControlToValidate="txtPasswordOnce" />
                </div>
            </div>
            <div class="row">
                <div class="form-group">
                    <asp:Label runat="server" CssClass="form-label" EnableViewState="False">Re-Type Password: </asp:Label>
                    <asp:TextBox runat="server" ID="txtPasswordSecond" CssClass="" TextMode="Password" EnableViewState="False" />
                    <asp:CustomValidator runat="server" ID="cusPasswordSecond" ControlToValidate="txtPasswordSecond" />
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    <asp:Button runat="server" ID="btnSubmit" Text="Create New User" CssClass="btn btn-default" OnClick="btnSubmit_Click" />

</div>