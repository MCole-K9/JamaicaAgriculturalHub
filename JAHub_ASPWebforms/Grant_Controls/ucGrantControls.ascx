<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucGrantControls.ascx.cs" Inherits="JAHub_ASPWebforms.Grant_Controls.ucGrantControls" %>

<asp:Panel ID="PnlDisplayUserControl" runat="server">
    <div class ="container">
    
    <div class="form-group">
        <label for="GrantRequirement" class="lblCreateGrant"><strong>Grant Details</strong>:</label>
        <textArea class="form-control" id="tAGrantRequirement" style="height:350px; width: 466px;" runat="server" name="S1" rows="1"> </textArea>
    </div>

    <div class="col-md-4" >
       <asp:button type="button" class="btn btn-secondary btn" runat="server" id="btnDelete" Text="Delete"></asp:button> 
    </div>

    <div class="col-md-4" >
       <asp:button type="button" class="btn btn-secondary btn" runat="server" id="btnUpdate" Text="Update"></asp:button> 
    </div>

    <div class="col-md-4" >
        <asp:CheckBox ID="cbSelect" runat="server" />  
    </div>



   </div>
</asp:Panel>


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
    .btn{
        width: 75px;
        height: 34px;
        margin-right: calc(100% - 75px);
    }
      
        </style>
