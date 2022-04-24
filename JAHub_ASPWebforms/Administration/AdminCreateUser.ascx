<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AdminCreateUser.ascx.cs" Inherits="JAHub_ASPWebforms.Administration.AdminCreateUser" %>

<div>
    <h2>Create New User</h2>
</div>

<div>
    <div class="row">
        <asp:DropDownList runat="server" ID="ddlUserRole" CssClass="btn btn-default input-sm col-lg-2"></asp:DropDownList>
    </div>
    <div class="row">
        <asp:CheckBox runat="server" ID="chkShowPassword" Text="Show Password:" TextAlign="Left" CssClass="col-lg-2 input-sm" OnCheckedChanged="chkShowPassword_CheckedChanged"/>
    </div>
    
    <asp:UpdatePanel runat="server" ID="udpPassword" OnLoad="udpPassword_Load">
        <ContentTemplate>
            <div class="row">
                <div class="form-group">
                    <asp:Label runat="server" CssClass="form-label">Password: </asp:Label>
                    <asp:TextBox runat="server" ID="txtPasswordOnce" CssClass="" TextMode="Password"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="form-group">
                    <asp:Label runat="server" CssClass="form-label">Re-Type Password: </asp:Label>
                    <asp:TextBox runat="server" ID="txtPasswordSecond" CssClass="" TextMode="Password"></asp:TextBox>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>

</div>