<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucWebBlog.ascx.cs" Inherits="JAHub_ASPWebforms.ucWebBlog" %>

<div class="well well-lg Blog">
    <div class="BlogDetails-Wrap" style="height:100%;">
        <h5>Title:<b runat="server" id="lblTitle"></b></h5>
        <h5>Author:<b runat="server" id="lblAuthor"></b></h5>
        <h5>Date Published:<b runat="server" id="lblPublishedDate"></b></h5>
        <h5>Description:<b runat="server" id="lblDescription"></b></h5>
    </div>
    <div class="View-Rating-Wrap" style="height:100%;">
        <asp:button type="button" class="btn btn-default btnView" runat="server" id="btnView" OnClick="btnView_Click" Text="View"></asp:button>
        <button type="button" class="btn btn-basic btnRating"><span class="glyphicon glyphicon-thumbs-up" style="margin-right: 5px; color:black; font-size:large;"></span><span class="badge" runat="server" id="lblRating">7</span></button>
    </div>
    
</div>
<style>
    .well{
        background-color: lightseagreen;
        box-shadow: 0 0 10px 1px rgba(0,0,0,0.4);
        height: 162px;
    }
    .View-Rating-Wrap{
        display:flex;
        flex-direction: column;
        justify-content: space-between;
        align-items: end;
    }
    .btnView, .btnRating
    {
         width: fit-content;
         height: 34px;
    }
    .btnRating{
        display:flex;
        align-items:center;
    }
    .Blog{
        display: flex;
        justify-content:space-between;
        align-items: start;
    }
    p{
        margin:0;
    }
    .pad{
        padding:10px;
        margin-bottom:5px;
        }
    ul{
        list-style: none;
    }
    .ViewButton{
      float:right;
        height: 26px;
    }
    .blog-text-wrapper{
        display:flex;
        flex-direction: column;
        justify-content: space-between;
    }
    b{
        margin-left:10px;
    }
</style>
