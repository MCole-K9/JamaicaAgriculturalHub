<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdministrationPage.aspx.cs" Inherits="JAHub_ASPWebforms.AdministrationPage" MasterPageFile="~/Site.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent" ID="AdminContent">
    <script type="text/javascript">

        function OpenDeleteModal() {
            $('#deleteModal').modal('show');
        }

        function CloseDeleteModal() {
            $('#deleteModal').modal('hide');
        }

        function OpenUserOptions() {
            $('#divUserOptions').removeClass('invisible');
            $('#divUserOptions').addClass('visible');
        }

        function CloseUserOption() {
            $('#divUserOptions').removeClass('visible');
            $('#divUserOptions').addclass('invisible');
        }
    </script>
    
    
    <div class ="row">
        <asp:Button runat="server" ID="btnSelectUser" Text="Select User" CssClass="btn btn-default input-sm col-sm-2" OnClick="btnSelectUser_Click"/>
        <asp:Button runat="server" ID="btnCreateNewUser" Text="Create New User" CssClass="text btn btn-default input-sm col-sm-2" OnClick="btnCreateNewUser_Click"/>
        <!-- Options that should only become available when a user is selected-->
        <asp:UpdatePanel runat="server" ID="udpUserOptions">
            <Triggers>
            </Triggers>
            <ContentTemplate>
                <asp:Label runat="server" ID="lblCurrentUser" CssClass="input-sm col-sm-2">Current User: none selected</asp:Label>
                <div id="divUserOptions" class="invisible">
                    <asp:Button runat="server" ID="btnDeleteUser" Text="Delete User" CssClass="btn btn-default input-sm col-sm-2" OnClick="btnDeleteUser_Click"/>
                    <asp:Button runat="server" ID="btnEditUser" Text="Edit User" CssClass="btn btn-default input-sm col-sm-2" OnClick="btnEditUser_Click"/>
                    <asp:Button runat="server" ID="btnViewModeration" Text="View User Moderation" CssClass="btn btn-default input-sm col-sm-2" OnClick="btnViewModeration_Click" />
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
        
    </div>

    <asp:UpdatePanel runat="server" ID="udpAdminPlaceholder">
        <ContentTemplate>
            <asp:PlaceHolder runat="server" ID="phAdministration">
            </asp:PlaceHolder>
        </ContentTemplate>
    </asp:UpdatePanel>
    


    <div class="modal" id="deleteModal">
        <div class="modal-dialog center-block">
            <div class="modal-content modal-sm center-block">
                <div class="modal-body">
                    <div class="row center-block">
                        <p class="text">Are you sure you want to delete this account?</p>
                    </div>
                    <div class="row center-block">
                        <asp:Button runat="server" ID="btnDeleteYes" Text="Yes" CssClass="btn btn-danger col-lg-4 input-sm text-left" 
                            OnClick="btnDeleteYes_Click" />
                        <div class="col-lg-4 input-sm"></div>
                        <asp:Button runat="server" ID="btnDeleteNo" Text="No" CssClass="btn btn-default col-lg-4 input-sm text-right" 
                            OnClick="btnDeleteNo_Click"/>
                    </div>
                </div>
            </div>
        </div>
    </div>
    
</asp:Content>