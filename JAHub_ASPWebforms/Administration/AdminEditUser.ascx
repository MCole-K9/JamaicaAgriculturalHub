<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AdminEditUser.ascx.cs" Inherits="JAHub_ASPWebforms.Administration.AdminEditUser" %>

<%@ Register Src="~/Verification/usrNameBlock.ascx" TagName="NameBlock" TagPrefix="uc"%>

<script>

    function RaiseSubmitModal() {
        $('#submitModal').modal('show');
    }

    function CloseSubmitModal() {
        $('#submitModal').modal('hide');
    }

</script>


<div>
    <h2>Edit Information for user <%= UserName %> (ID: <%= UserId %>)</h2>
    <p>Fields marked with '*' are Mandatory</p>
</div>

<div>
    <div>
        <uc:NameBlock ID="nbNewUserName" runat="server" />
    </div>
    <div class="row center-block">
        <div class="center-block">
            <asp:Label runat="server" ID="lblEmail" EnableViewState="False" Text="Email: " CssClass="col-1g-1 input-sm text" />
            <asp:TextBox runat="server" ID="txtEmail" EnableViewState="False" CausesValidation="True"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" ID="reqEmail" ControlToValidate="txtEmail" ErrorMessage="Field cannot be blank!" />
            <asp:RegularExpressionValidator runat="server" ErrorMessage="Must be a Valid Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                ControlToValidate="txtEmail" EnableViewState="False" EnableClientScript="False"></asp:RegularExpressionValidator>
        </div>
    </div>
    
    
    <asp:UpdatePanel runat="server" ID="udpPassword" UpdateMode="Conditional" ChildrenAsTriggers="True">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="chkShowPassword" EventName="CheckedChanged" />
            <asp:AsyncPostBackTrigger ControlID="btnSubmit" EventName="Click" />
        </Triggers>
        <ContentTemplate>
            <!--<div class="row">
                <asp:CheckBox runat="server" ID="chkShowPassword" Text="Show Password:" TextAlign="Left" CssClass="col-lg-2 input-sm" 
                    OnCheckedChanged="chkShowPassword_CheckedChanged" AutoPostBack="True" CausesValidation="False" EnableViewState="False" />
            </div>-->
            <div class="row center-block">
                <div class="form-group center-block">
                    <asp:Label runat="server" CssClass="form-label col-1g-2" EnableViewState="False">Password: </asp:Label>
                    <asp:TextBox runat="server" ID="txtPasswordOnce" CssClass="" TextMode="SingleLine" EnableViewState="False" CausesValidation="True" ViewStateMode="Inherit"></asp:TextBox>
                    <asp:CustomValidator ID="cusPasswordOnce" runat="server" ControlToValidate="txtPasswordOnce" 
                        ErrorMessage="" OnServerValidate="cusPasswordOnce_ServerValidate" EnableClientScript="False" />
                    <asp:RequiredFieldValidator ID="reqPasswordOnce" runat="server" ControlToValidate="txtPasswordOnce" ErrorMessage="Field Cannot be Blank!"/>
                </div>
            </div>
            <div class="row center-block">
                <div class="form-group center-block">
                    <asp:Label runat="server" CssClass="form-label col-1g-3" EnableViewState="False">Re-Type Password: </asp:Label>
                    <asp:TextBox runat="server" ID="txtPasswordSecond" CssClass="" TextMode="SingleLine" EnableViewState="False" />
                    <asp:CustomValidator runat="server" ID="cusPasswordSecond" ControlToValidate="txtPasswordSecond" 
                        ErrorMessage="" OnServerValidate="cusPasswordSecond_ServerValidate" EnableClientScript="False" />
                    <asp:RequiredFieldValidator ID="reqPasswordSecond" runat="server" ControlToValidate="txtPasswordSecond" ErrorMessage="Field Cannot be Blank!"/>
                </div>
            </div>
                <asp:Button runat="server" ID="btnSubmit" Text="Create New User" CssClass="btn btn-default" OnClick="btnSubmit_Click" CausesValidation="False" />
        </ContentTemplate>
    </asp:UpdatePanel>


    <div class="modal" id="submitModal">
        <div class="modal-dialog">
            <div class="modal-content center-block">
                <div class="modal-header">
                    <asp:Label ID="lblSubmitTitle" runat="server"/>
                </div>
                <div class="modal-body center-block">
                    <div class="row">
                        <asp:Label runat="server" ID="lblSubmitText"/>
                    </div>
                    <div class="row center-block">
                        <button class="btn btn-default input-sm col-lg-3" data-dismiss="modal">Close</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>