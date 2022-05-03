<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GrantDetails.aspx.cs" Inherits="JAHub_ASPWebforms.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <nav class="navbar navbar-default">
            <div class="container-fluid">
                <ul class="nav navbar-nav">
                    <li class="active"><a href="WfHome">Home</a></li>
                    <li class="active"><a href="WfCreateGrants">Create Grants</a></li>
                    <li class ="active"><a href="WfViewAllMyGrants">View All Grants</a></li>
                    <li class ="active"><a href="WfUpdateGrants">Update Grants</a></li>
                    <li class ="active"><a href="WfDeleteGrants">View All Grants</a></li>
                </ul>
            </div>
        </nav>
    </div>
    <div class =" container mt-5">
        <div class="form-group">
            <label class=" lblCreateGrant" for="title">
            Title:</label>
            <input type="text" class="form-control" id="txtTitle" , placeholder="RADA Grant" required runrat ="server">
        </div>
        <div class="form-group">
            <label for="title">
            Application Number:</label>
            <input type="text" class="form-control" id="txtApplicationNumber" , placeholder="0124" required runrat="server">
        </div>
        <div class="form-group">
            <label for="GrantDecription" class="lblCreateGrant">
            <strong>Description</strong>:</label>
            <textArea class="form-control" id="tAGrantdescription" style="height:350px;" runat="server" cols="20" name="S1" rows="1"> </textArea>
        </div>
        <div class="form-group">
            <label for="GrantRequirement" class="lblCreateGrant">
            <strong>Requirements</strong>:</label>
            <textArea class="form-control" id="tAGrantRequirement" style="height:350px;" runat="server" cols="20" name="S2" rows="1"> </textArea>
        </div>
        <div  class="col-md-5" style = "margin-top:50px;">
            <h3>Upload File</h3>
            <asp:FileUpload ID="FileUpload1"  runat="server" AllowMultiple="true" Height="44px" Width="290px"/>
        </div>

        <div  class="col-md-5" style = "margin-top:50px;">
            <h3>Upload File</h3>
            <asp:Button ID="Button1" runat="server" Text="Download" Height="24px" Width="107px" /> 
        </div>
        <div>
            <asp:button type="button" class="btn btn-primary btnSubmit" runat="server" id="btnSubmit" Text="Submit"></asp:button>
        </div>
    </div>
    <style>

            .container{
                padding: 0;
            }
            input[type="text"]{
                max-width: 50%;
            }
            .lblCreateGrant
            {
                margin-top:30px;
                max-width:100px;
                
            }
            .btnSubmit{
                width: 75px;
                height: 34px;
                margin-right: calc(100% - 75px);
            }
      
        </style>








</asp:Content>
