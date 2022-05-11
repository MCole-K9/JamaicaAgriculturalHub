<%@ Page Title="" Language="C#" MasterPageFile="~/UserPortal.Master" AutoEventWireup="true" CodeBehind="MyAccount.aspx.cs" Inherits="JAHub_ASPWebforms.MyAccount" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href='https://unpkg.com/boxicons@2.1.2/css/boxicons.min.css' rel='stylesheet'>

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

        .name{
        display: grid;
        grid-template-columns: repeat(3, 2fr);
        padding-top: 15px;
        padding-bottom: 16px;
         
        }

        .name > div {
       padding: 4px 0px 0px; 
       margin: 0px 24px 0px 0px;
       border-bottom-color: black;
       /*margin-top: 1rem;*/
        }

        .titles > h4{
            padding-left: 8px;
        }
       

         a:link{
            text-decoration: none;
            color: black;
            transition: all 300ms ease;
        }

        a:hover{
            background-color: #b6adad;

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

    
    </style>


    <div class="auto-style2" style="margin-left: 15px; ">
        <h1>My Account</h1>

        <div class="content-holder">
            <div class="section1" style="border: 1px solid #000000; border-radius: 10px">
                <h4>Your Account Info</h4>
                <p>Personal information and alternatives for managing it. Others can see 
                   some of your information, such as your name, profile picture, and gender. 
                   A summary of your account profile is also available.
                </p>
                <div class="right">
                    <%--add image here--%>
                </div>
            </div>


            <div class="form" style="border: 1px solid #000000;  border-radius: 10px; margin-top: 2rem; height: 100%">
                <div class="person-form">
                    <div class="fields">
                        <div class="titles">
                        <h4>Basic Info</h4>
                    </div>

                        <a href="#" class="name">
                            <div class="titles">
                                <h4>Name</h4>
                            </div>

                            <div class="titles">
                                <asp:Label ID="lblFullName" runat="server" Text=""></asp:Label>
                            </div>

                            <div class="titles">
                                <i class='bx bx-right-arrow-alt' style="  font-size:50px; padding-left: 50%;"></i>
                            </div>
                        </a>

                        <a href="#" class="name">
                            <div class="titles">
                                <h4>Date of Birth</h4>
                            </div>

                            <div class="titles">
                                <asp:Label ID="lblBirthDay" runat="server" Text="Add your Date of Birth"></asp:Label>
                            </div>

                            <div class="titles">
                                <i class='bx bx-right-arrow-alt' style="  font-size:50px; padding-left: 50%;"></i>
                            </div>
                        </a>
                        
                        <a href="#" class="name">
                            <div class="titles">
                                <h4>Gender</h4>
                            </div>

                            <div class="titles">
                                <asp:Label ID="lblGender" runat="server" Text=""></asp:Label>
                            </div>

                            <div class="titles">
                                <i class='bx bx-right-arrow-alt' style="  font-size:50px; padding-left: 50%;"></i>
                            </div>
                        </a>
                    </div>
                </div>
             </div>

            <div class="form" style="border: 1px solid #000000;  border-radius: 10px; margin-top: 2rem; height: 100%">
                <div class="contact-form">
                    <div class="titles">
                        <h4>Contact information</h4>
                    </div>

                     <a href="#" class="name">
                            <div class="titles">
                                <h4>Email</h4>
                            </div>

                            <div class="titles">
                                <asp:Label ID="lblEmail" runat="server" Text=""></asp:Label>
                            </div>

                            <div class="titles">
                                <i class='bx bx-right-arrow-alt' style="  font-size:50px; padding-left: 50%;"></i>

                            </div>
                        </a>

                        <a href="#" class="name">
                            <div class="titles">
                                <h4>Telephone Number</h4>
                            </div>

                            <div class="titles">
                                <asp:Label ID="lblTelephone" runat="server" Text="Add your Telephone Number"></asp:Label>
                            </div>

                            <div class="titles">
                                <i class='bx bx-right-arrow-alt' style="  font-size:50px; padding-left: 50%;"></i>
                                
                            </div>
                        </a>


                </div>

            </div>
        </div>

</div>


</asp:Content>
