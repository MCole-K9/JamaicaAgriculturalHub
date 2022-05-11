<%@ Page Title="" Language="C#" MasterPageFile="~/UserPortal.Master" AutoEventWireup="true" CodeBehind="Security.aspx.cs" Inherits="JAHub_ASPWebforms.Security" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <style>

        .containers {
        position: relative;
        max-width: 900px;
        width: 100%;
        border-radius: 6px;
        padding: 30px;
        margin: 0 15px;
        background-color: #fff;
        box-shadow: 0 5px 10px rgba(0,0,0,0.1);

        }


     .input-field {
        display: flex;
        width: calc(100% / 3 - 15px);
        flex-direction: column;
        margin: 4px 0 35px;
    }

    .input-field label {
        font-size: 12px;
        font-weight: 500;
        color: #2e2e2e;
    }

    .input-field input, select {
        outline: #4070f4;
        font-size: 14px;
        font-weight: 400;
        color: #333;
        border-radius: 5px;
        border: 1px solid #aaa;
        padding: 0 15px;
        height: 42px;
        margin: 8px 0;
    }

  

    @media (max-width: 750px) {
        .container form {
            overflow-y: scroll;
        }

            .container form::-webkit-scrollbar {
                display: none;
            }

        form .fields .input-field {
            width: calc(100% / 2 - 15px);
        }
    }

    @media (max-width: 550px) {
        form .fields .input-field {
            width: 100%;
        }
    }
        .auto-style1 {
            height: 49px;
        }
        .auto-style2 {
            padding-right: 15px;
            padding-left: 15px;
            margin-right: auto;
            margin-left: auto;
            height: 565px;
        }
    </style>


    <div class="auto-style2">
        <h1>Security</h1>

        <div class="content-holder">
            <div class="section1" style="border: 1px solid #000000">
                <h4>Change Password</h4>
                <p>You may configure and change the security settings for login in this section. 
                    Use a strong, unique password to keep your JAH \r\naccount safe.</p>
                <div class="right">
                    <%--add image here--%>
                </div>
            </div>

            <div class="Error " style="padding-top: 2%">
                 <asp:Label ID="lblMessage" runat="server" Text="Label" Visible="False"></asp:Label>
            </div>

            <div class="form" style="border: 1px solid #000000; margin-top: 2rem; height: 100%">
                <div class="password-form" style="padding: 20px;">
                    <div class="fields">

                        <div class="input-field">
                            <label>Enter old password</label>
                            <asp:TextBox ID="txtOldPassword" runat="server" placeholder="Enter old password" TextMode="Password"></asp:TextBox>
                            <asp:CustomValidator ID="CustomValidatorOldPassword" runat="server" ControlToValidate="txtOldPassword" Display="Dynamic" ErrorMessage="Password dosen't match old password" ForeColor="Red" OnServerValidate="CustomValidatorOldPassword_ServerValidate"></asp:CustomValidator>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorOldPassword" runat="server" ErrorMessage="Enter old Password" ControlToValidate="txtOldPassword" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>

                        <div class="input-field">
                            <label>Enter a password</label>
                            <asp:TextBox ID="txtPassword" runat="server" placeholder="Enter a password" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" runat="server" ErrorMessage="Enter a Password" ControlToValidate="txtPassword" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>

                        <div class="input-field">
                            <label>Confirm password</label>
                            <asp:TextBox ID="txtConfirmPassword" runat="server" placeholder="Re-enter your password" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorConPassword" runat="server" ErrorMessage="This field can't be blank" ControlToValidate="txtConfirmPassword" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="CompareValidatorConPassword" runat="server" ErrorMessage="Password not Matched" ControlToValidate="txtConfirmPassword" ForeColor="Red" ControlToCompare="txtPassword" Display="Dynamic"></asp:CompareValidator>
                        </div>


                    </div>
                </div>


                <div class="auto-style1">
                    <asp:Button class="btnUpdate" ID="btnUpdatePassword" runat="server" Text="Update Password" Style="width: 50%; margin-left: 30%" OnClick="btnUpdatePassword_Click" />
                </div>
            </div>

       
                    
    </div>

        </div>


</asp:Content>
