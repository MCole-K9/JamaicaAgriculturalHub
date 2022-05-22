<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GeneraslInfoUserControls.ascx.cs" Inherits="JAHub_ASPWebforms.GrantDisplay_Controls.GeneraslInfoUserControls" %>

    <table class="nav-justified">
        <tr>
            <td style="width: 660px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 660px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 660px">
                <input id="Text1" type="text"  class ="Display" /></td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 660px">
                <asp:CheckBox ID="CheckBox1" runat="server" Class ="Checkbox" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 660px">
                <asp:Button ID="Button1" runat="server" Text="Button" class ="btnSubmit" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 660px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>



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

         .Display{
           width: 1200px;
           height: 200px;
           
            
        }

         .Checkbox{
            width: 75px;
            height: 34px;
            margin-right: calc(100% - 50px);
            
        }
      
    </style>

