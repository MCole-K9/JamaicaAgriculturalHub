<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayBlog.aspx.cs" Inherits="JAHub_ASPWebforms.DisplayBlog" MasterPageFile="~/Site.Master"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <nav class="navbar navbar-default">
  <div class="container-fluid">
    <ul class="nav navbar-nav">
      <li class="active"><a href="Blog">AgriBlogs</a></li>
      <li><a href="CreateBlog">Create</a></li>
      <li><a href="MyBlogs">My Blogs</a></li>
    </ul>
  </div>
</nav>
    <div>
        <div class="container">
         <div class="jumbotron">
            <h1 runat="server" id="lblTitle">Blog Title</h1>
              <h4 runat="server" id="lblAuthor">Author:</h4>
              <h4 runat="server" id="lblPublishDate">Date Published:</h4>
              <h4 runat="server" id="lblDescription">Description:</h4>
          </div>
            </div>
        <div class="col-sm-8">
            <blockquote>
                <p runat="server" id="lblBlogBody">Some text in the body of the blog</p>
         </blockquote>

            <div class="ratingWrap">
                <div class="updateBtnWrap">
                    <asp:button type="button" class="btn btn-default btn-success fit" runat="server" Text="Edit Blog" ID="btnEditBlog" Visible="False" OnClick="btnEditBlog_Click">
                    </asp:button>
                    <asp:button type="button" class="btn btn-default btn-danger fit" runat="server" Text="Delete Blog" ID="btnDeleteBlog" Visible="False" OnClick="btnDeleteBlog_Click">
                    </asp:button>
                </div>
                <div class="ratingBtnWrap">
                    <button type="button" class="btn btn-default btnRating btn-primary fit" runat="server" id="btnRatingUp" onserverClick="RatingUp">
                        <span class="glyphicon glyphicon-thumbs-up" style="color:white; font-size:large;"></span>
                    </button>
                    <button type="button" class="btn btn-default btnRating btn-primary fit" runat="server" id="btnRatingDown" onserverClick="RatingDown">
                        <span class="glyphicon glyphicon-thumbs-down" style="color:white; font-size:large;"></span>
                    </button>
                </div>
            </div>

        </div>
        
    </div>
    <style>
        .fit{
            width: fit-content;
        }
        .ratingWrap, .ratingBtnWrap{
            display: flex;
            justify-content: space-between;
        }
        .ratingBtnWrap{
            width: 95px;
        }
        .ratingWrap label{
            float: left;
        }
        .btnRating{
            width: fit-content;
        }
        .container{
            padding: 0;
        }
        form{
            height:100%;
        }
        .col-sm-8{
            width:100%;
            height:fit-content
        }
         .row .content {
        height: 900px;
    }
         .jumbotron{
             background-color:lightseagreen;
             color: white;
         }
    </style>
</asp:Content>