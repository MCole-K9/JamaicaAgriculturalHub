<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="USERCONTROL_GrantDDisplay.ascx.cs" Inherits="JAHub_ASPWebforms.Grant_Controls.USERCONTROL_GrantDDisplay" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
        margin-top: 0px;
    }
    #TextArea1 {
        width: 563px;
        height: 154px;
    }

    .TextCreation {
        width: 200px;
        max-height: 30px;
    }

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
           /* <-- margin-right: calc(100% - 50px);-->*/
            
        }


        input {
  width: 13px;
  height: 13px;
  padding: 0;
  margin:0;
  vertical-align: bottom;
  position: relative;
  top: -1px;
  *overflow: hidden;
}


    /*.auto-style3 {
        width: 454px;
    }
    .auto-style4 {
        width: 347px;
    }*/


    .auto-style5 {
        width: 24px;
    }


    .auto-style7 {
        width: 402px;
    }
    

</style>

<asp:Panel ID="Panel1" runat="server" Height="354px" Width="765px">
    <table class="auto-style1">

        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
        </tr>
        <tr>
            <td >
                <asp:TextBox ID="txtTitle" class="TextCreation" runat="server"></asp:TextBox>
            </td>

            <td class="auto-style5">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:TextBox ID="TextBox1" runat="server" Height="114px" TextMode="MultiLine" Width="525px"></asp:TextBox>
            </td>
            <td class="auto-style5">
                <asp:CheckBox ID="CheckBox1" runat="server" style="margin-right:calc(100% - 100%); text-align: center;" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">
                &nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Button ID="Delete" runat="server" class="button" style="margin-right:calc(100% - 100%)" Text="Delete" />
                <asp:Button ID="Update" runat="server" class="button" style="margin-right:calc(100% - 75%)" Text="Update" />
            </td>
            <td class="auto-style5">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
        </tr>
    </table>
</asp:Panel>

