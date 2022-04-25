<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UsrReview.ascx.cs" Inherits="JAHub_ASPWebforms.Shop_Controls.UsrReview" %>


<div class="panel">
    <div class="panel-body">
        <div class="media">
            <div class="media-left media-top">
                <img src="http://vtdics.com/ead22/Avatar.png" class="media-object" style="width: 60px">
            </div>
            <div class="media-body">
                <h4 runat="server" id="Name" class="media-heading">Name</h4>
                <p><span id="Rating" runat="server"></span> Star</p>
                <p runat="server" id="Headline">Headline</p>
                <p runat="server" id="Comment">Headline</p>
            </div>
        </div>
    </div>

</div>
