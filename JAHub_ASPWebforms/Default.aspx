<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="JAHub_ASPWebforms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1 class="fade"><b>Jamiaca Agricultural Hub</b></h1>
        <p class="lead" style="color: #fefefe;">Welcome to the Official Webpage for the Jamaica Argicultural Hub</p>
    </div>


  <div class="container-fluid bg-grey">
  <div class="row">
    <div class="col-sm-4">
      <span class="glyphicon glyphicon-globe logo slide"></span>
    </div>
    <div class="col-sm-8">
      <h2>Our Values</h2><br>
      <h4 class="slide"><strong>MISSION:</strong> Food prices are high and constantly increasing as the economy rallies from the
devastating impact of the Covid-19 pandemic. We aim to provide customers with easy access to farmers and their produce as well as providing farmers with easy access to customers to increase revenue and promote the industry</h4><br>
      <h4 class="slide"><strong>Using our platform we aim to:</strong> </h4>
        <ul>
          <li>Enable grater levels of collaboration amongst local producers</li>
          <li>Sensitize young persons on the local productive sector to enable more young
                persons to produce locally</li>
          <li>Facilitate the provision of grant funding for young producers</li>
          <li>Tackle existing supply chain issues</li>
          <li>Facilitate grater levels of investment and promotion of the local productive
               sector</li>
        </ul>
    </div>
  </div>
</div>


    <div class="row panelWrapper" style="margin-top:30px;">
        <div class="col-md-4">
           <div class="panel panel-success" >
              <div class="panel-heading"><h2 class="text-center" style="margin:5px;">Online Farmers Market</h2></div>
               <div class="panel-body"><img src="Resources/freshproduce.jpg" /></div>
              <div class="panel-body"> Connect and purchase goods from local farmers online! Browse our wide variety of fruit, vegetables, ground provisions and other argicultural products on the Shop section of our website</div>
               <div style="display:flex; justify-content:right; padding: 0 10px 10px 0;">
                <a class="btn btn-default" href="Shop">Shop Now &raquo;</a>
            </div>
            </div>
        </div>
        <div class="col-md-4">
            <div class="panel panel-success" >
              <div class="panel-heading"><h2 class="text-center" style="margin:5px;">Sign up</h2></div>
                <div class="panel-body"><img src="Resources/farmer-icon.png" /></div>
              <div class="panel-body"> Consider signing up with us. This will allow you to purchase goods, create blogs and much more. You can also apply as a farmer to access benefits such as grants and a platform to sell your goods </div>
               <div style="display:flex; justify-content:right; padding: 0 10px 10px 0;">
                <a class="btn btn-default" href="Default">Sign Up &raquo;</a>
            </div>
            </div>
        </div>
        <div class="col-md-4">
          <div class="panel panel-success" >
              <div class="panel-heading"><h2 class="text-center" style="margin:5px;">Apply for a Grant</h2></div>
              <div class="panel-body"><img src="Resources/grant-icon.jpg" /></div>
              <div class="panel-body"> To facilitate grater levels of investment and promotion of the local productive
               sector we provide, through the help of external organizations, grants to farmers to boost their production and provide financial assistance</div>
               <div style="display:flex; justify-content:right; padding: 0 10px 10px 0;">
                <a class="btn btn-default" href="Grants">Learn More &raquo;</a>
            </div>
            </div>
        </div>
    </div>

    <style>
        .panel:hover{
            box-shadow: 0 0 10px 1px rgba(0,0,0,0.4);
            transition: .3s;
        }
        .panelWrapper{
            height: 650px;
        }
        .jumbotron{
            background-image: url(Resources/landscape.jpg);

          }
        .logo {
            color: green;
            font-size: 300px;
          }   
        .container-fluid {
            padding: 30px 25px;
          }
        .bg-grey {
            background-color: #f6f6f6;
          }
          .slide {
            animation-name: slide;
            animation-duration: 1s;
            visibility: visible;
          }
          .fade {
            animation-name: rise;
            animation-duration: 2s;
            visibility: visible;
            animation-fill-mode: forwards;
          }
            @keyframes slide {
            0% {
              opacity: 0;
              transform: translateY(70%);
            } 
            100% {
              opacity: 1;
              transform: translateY(0%);
            }
          }
             @keyframes rise {
            0% {
              opacity: 0;
              transform: translateY(10%);
            } 
            100% {
              opacity: 1;
              transform: translateY(0%);
            }
          }
             .panel-body > img {
              width: 100%;
              height: 100%;
            }
    </style>
</asp:Content>
