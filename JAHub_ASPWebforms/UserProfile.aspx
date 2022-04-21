<%@ Page Title="User Profile" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="JAHub_ASPWebforms.UserProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style="text-align:center;">User Profile</h1>
  <div class="jumbotron">
    <div class="ProfilePicture">

    </div>
      <div class="ProfileInfo">

      </div>
  </div>
    <section>
          <ul class="nav nav-tabs nav-justified">
            <li class="active account-tab"><a>Account</a></li>
            <li class="security-tab"><a>Security</a></li>
            <li class="m2"><a>Menu 2</a></li>
            <li class="m3"><a>Menu 3</a></li>
          </ul>

        <div class="FrmWrapper account">
            <h3>Basic Info</h3>
            <div class="form-group">
            <label for="Fname">First Name:</label>
            <input type="text" class="form-control" id="fname">
          </div>
            <div class="form-group">
            <label for="Lname">Last Name:</label>
            <input type="text" class="form-control" id="lname">
          </div>
          <div class="form-group">
            <label for="DOB">Date of Birth:</label>
            <input type="date" class="form-control widthControl" id="dob">
          </div>
            <h3>Contact Info</h3>
            <div class="form-group">
            <label for="email">Email Address:</label>
            <input type="email" class="form-control" id="email">
          </div>
            <div class="form-group">
            <label for="Telephone">Telephone #:</label>
            <input type="tel" class="form-control" id="telephone">
          </div>
            <button type="submit" class="btn btn-default">Save</button>
        </div>
        <div class="FrmWrapper security">
            <div class="form-group">
            <label for="email">Email Address:</label>
            <input type="email" class="form-control" id="gmail">
          </div>
          <div class="form-group">
            <label for="pwd">Name:</label>
            <input type="password" class="form-control" id="pwd">
          </div>

        </div>
    </section>
    <style>
        button{
            width: fit-content;
        }
        .jumbotron{
            display: flex;
            justify-content: space-between;
        }
        .ProfilePicture{
            height: 300px;
            width: 300px;
            background-color: darkslategrey;
        }
        .ProfileInfo{
            background-color: #fefefe;
        }
        .FrmWrapper{
            padding: 15px;
            height: 500px;
        }
        .security{
            display:none;
        }
        .widthControl{
            width: 280px;
        }
    </style>
    <script>
        function Clear() {
            $(".nav").find("li").removeClass("active");
            $(".FrmWrapper").hide();
        }
        $(".account-tab").on("click", () => {
            Clear();
            $(".account-tab").addClass("active");
            $(".account").show();
         })
        $(".security-tab").on("click", () => {
            Clear();
            $(".security-tab").addClass("active");
            $(".security").show();
         })
            $(".m2").on("click", () => {
                $(".nav").find("li").removeClass("active");
                $(".m2").addClass("active");
            })
            $(".m3").on("click", () => {
                $(".nav").find("li").removeClass("active");
                $(".m3").addClass("active");
            })

    </script>
</asp:Content>
