<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateGrants.aspx.cs" Inherits="JAHub_ASPWebforms.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <nav class="navbar navbar-default">
         <%--   <div class="container-fluid">
                <ul class="nav navbar-nav">
                  <li class="active"><a href="WfHome">Home</a></li>
                  <li class="active"><a href="WfCreateGrants">Create Grants</a></li>
                  <li class ="active"><a href="WfViewAllMyGrants">View All Grants</a></li>
                  <li class ="active"><a href="WfUpdateGrants">Update Grants</a></li>
                  <li class ="active"><a href="WfDeleteGrants">View All Grants</a></li>
                </ul>
            </div> --%>
        </nav>
        </div>

    <div class =" container mt-5">
        <div class="form-group">
             <label class=" lblCreateGrant" for="title">Title:</label>
            <asp:TextBox class="form-control" style="max-width:400px" ID="txtTitle" placeholder="RADA Grant" required="txtTitle"   runat="server"></asp:TextBox>
        </div>

         <div class="form-group">
             <label for="Application_Number">Application Number:</label>
             <asp:TextBox class="form-control" ID="txtApplicationNumber" style="max-width:400px" placeholder="#9948" required="txtApplication"   runat="server"></asp:TextBox>
         </div>
        <div class="form-group">
            <label for="GrantDecription" class="lblCreateGrant"><strong>Description</strong>:</label>
            <textArea class="form-control" id="tAGrantdescription" style="height:350px;" runat="server"> </textArea>
        </div>

        <div> 
            <p>  
            <asp:Label runat="server" ID="ShowDate" ></asp:Label>  
            </p>  
        </div>

        <div class="form-group">
            <label for="GrantRequirement" class="lblCreateGrant"><strong>Requirements</strong>:</label>
            <textArea class="form-control" id="tAGrantRequirement" style="height:350px;" runat="server"> </textArea>
        </div>

        <div  class="col-md-6" style = "margin-top:50px;">    
            <h3>Upload File</h3>    
            <asp:FileUpload ID="FileUpload1"  runat="server" AllowMultiple="true"/>    
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


