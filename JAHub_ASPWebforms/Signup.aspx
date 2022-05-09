<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="JAHub_ASPWebforms.Signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
    <!----======== CSS ======== -->
     
    <!----===== Iconscout CSS ===== -->
    <link rel="stylesheet" href="https://unicons.iconscout.com/release/v4.0.0/css/line.css">

    <link href="SignupCss.css" rel="stylesheet" />

    <div class="containers">
        <header>Registration</header>

        
            <div class="form first">
                <div class="details personal">
                    <span class="title">Personal Details</span>

                    <div class="fields">
                        <div class="input-field">
                            <label>First Name</label>
                            <table>
                                <tr>
                                    <td>
                                        <asp:TextBox ID="txtFirstName" runat="server" placeholder="Enter your first name" ></asp:TextBox>
                                    </td>
                                    <td style="width:233px" class="modal-sm">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorFirstName" runat="server" ErrorMessage="First name is Required" ControlToValidate="txtFirstName" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                    </td>
                                    <td>
                                        <%--<asp:RangeValidator ID="RangeValidatorFName" runat="server" ErrorMessage="RangeValidator" ControlToValidate="txtFirstName"  ForeColor="Red"></asp:RangeValidator>--%>
                                    </td>
                                </tr>
                            </table>
                        </div>

                        <div class="input-field">
                            <label>Middle Name</label>
                             <table>
                                <tr>
                                    <td>
                                        <asp:TextBox ID="txtMiddleName" runat="server" placeholder="Enter your middle name"></asp:TextBox>
                                    </td>
                                    <td style="width: 262px">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorMiddleName" runat="server" ErrorMessage="Middle name is Required" ControlToValidate="txtMiddleName" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                            </table>
                            
                        </div>

                        <div class="input-field">
                            <label>Last Name</label>
                            <table>
                                <tr>
                                    <td>
                                        <asp:TextBox ID="txtLastName" runat="server" placeholder="Enter last name"></asp:TextBox>
                                    </td>
                                    <td style="width: 262px">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorLastName" runat="server" ErrorMessage="Middle name is Required" ControlToValidate="txtLastName" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                            </table>
                        </div>

                        <div class="input-field">
                            <label>Email</label>
                            <table>
                                <tr>
                                    <td>
                                        <asp:TextBox ID="txtEmail" runat="server" placeholder="Enter your email"></asp:TextBox>
                                    </td>
                                    <td style="">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server" ErrorMessage="Email is Required" ControlToValidate="txtEmail" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                    <td>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Enter a in the format(someone@email.com)" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="Red"></asp:RegularExpressionValidator>
                                    </td>
                                </tr>
                            </table>
                        </div>
                        

                        <div class="input-field">
                            <label>Gender</label>
                            <asp:DropDownList ID="Gender" runat="server" style="width:280px;">
                                <asp:ListItem>I&#39;d Rather Not Say</asp:ListItem>
                                <asp:ListItem>Male</asp:ListItem>
                                <asp:ListItem>Female</asp:ListItem>
                                
                            </asp:DropDownList>
                        </div>

                        <div class="input-field">
                            <label>Enter a password</label>
                            <table>
                                <tr>
                                    <td>
                                        <asp:TextBox ID="txtPassword" runat="server" placeholder="Enter a password" TextMode="Password"></asp:TextBox>
                                    </td>
                                    <td style="width: 262px">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" runat="server" ErrorMessage="Enter a Password" ControlToValidate="txtPassword" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                            </table>
                            
                        </div>

                         <div class="input-field">
                            <label>Confirm password</label>
                             <table>
                                <tr>
                                    <td>
                                        <asp:TextBox ID="txtConfirmPassword" runat="server" placeholder="Re-enter your password" TextMode="Password"></asp:TextBox>
                                    </td>
                                    <td style="width: 232px">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorConPassword" runat="server" ErrorMessage="This field can't be blank" ControlToValidate="txtConfirmPassword" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                    <td>
                                        <asp:CompareValidator ID="CompareValidatorConPassword" runat="server" ErrorMessage="Password not Matched" ControlToValidate="txtConfirmPassword" ForeColor="Red" ControlToCompare="txtPassword" Display="Dynamic"></asp:CompareValidator>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        <div class="Error">
            <asp:Label ID="lblMessage" runat="server" Text="Label" Visible="False"></asp:Label>
        </div>

        <button class="sumbit"  id="btnSubmit1"  runat="server" onserverclick="btnsubmit_serverclick" type="submit" style="width: 50%; margin-left:30%" >
            <span class="btnText">Submit</span>
            <i class="uil uil-navigator"></i>
        </button>

  
                    
    </div>

    <!--<script src="script.js"></script>-->




</asp:Content>
