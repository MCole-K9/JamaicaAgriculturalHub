<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucGeneralGrantInfo.ascx.cs" Inherits="JAHub_ASPWebforms.GrantDisplay_Controls.GeneralGrantInfo" %>

<div class ="container mt-5">
    <asp:Panel ID="PnlDisplayUserControl" class ="max-width" runat="server">
    <div class="form-group">
        <label for="GrantRequirement" class="lblCreateGrant"><strong>Grant Details</strong>:</label>
        <textArea class="form-control" id="tAGrantRequirement" style="height:300px; width: 400px;" runat="server" name="S1" rows="1"> </textArea>
    </div>
   
        <div  >
        <asp:CheckBox ID="cbSelect" runat="server" />  
    </div>

    <div class="col-md-5" >
        <asp:Button ID="btnUpdate" runat="server" class="btn btn-secondary button" Text="Update" type="button" />
        <asp:Button ID="btnDelete" runat="server" class="btn btn-secondary button" Text="Delete" type="button" />
    </div>

    <div class="col-md-6" >
    </div>

    


    </asp:Panel>
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
        .button{
            width: 75px;
            height: 34px;
           /* margin-right: calc(100% - 75px*/);
        }
      
    </style>


</asp:Content>
