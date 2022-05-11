<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Blog.aspx.cs" Inherits="JAHub_ASPWebforms.WebFrmBlog" MasterPageFile="~/Site.Master" Title="Blog"%>
<%@register src = "~/ucWebBlog.ascx" TagName="WebControl" TagPrefix="blogControl"%>

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
            <h1>Agricultural Blogs</h1>
            <p>Explore a multitude of blogs shared by farmers, contibutors and users giving insight, general information and expertise on the Agricultural Sector</p>
          </div>
        </div>
        <div class="SortSearchWrap">
            <div class="input-group">
                    <input type="text" class="form-control" placeholder="Search" id="txtSearch" runat="server"/>
                    <div class="input-group-btn">
                      <button runat="server" class="btn btn-primary btnSearch" type="submit" onserverclick="btnSearch_Click" Text="Search">
                          <span class="glyphicon glyphicon-search"></span>
                      </button>
                    </div>
                  </div>

            <div class="input-group cboSort" style="width:fit-content">
                <p style="font-size: large; display: flex; flex-direction: column; justify-content: center;">Sort:</p>
             <asp:DropDownList ID="dropDownSort" runat="server" Width="150px" AutoPostBack="true" OnSelectedIndexChanged="dropDownSort_SelectedIndexChanged">
                <asp:ListItem Text="Select an option" Selected="True"/>
                <asp:ListItem Text="Oldest" Value="Oldest"/>
                <asp:ListItem Text="Rating" Value="Rating"/>
                <asp:ListItem Text="A-Z" Value="A-Z"/>
                <asp:ListItem Text="Z-A" Value="Z-A"/>
            </asp:DropDownList>
            </div>
           
        </div>
                  
        <div style="height:600px; margin-bottom: 50px;">
             <asp:Panel ID="pnlBlogContainer" runat="server" Height="100%" BorderStyle="Groove" CssClass="pnlBlogContainer">
        </asp:Panel>
        </div>
       
    </div>
    <style>
        .container{
            padding: 0;
        }
        .SortSearchWrap{
            display: inline-flex;
            justify-content: space-between;
            width:100%;
        }
        form{
            height:100%;
        }
        .AgriBlogDesc{
            margin-bottom: 50px;
        }
        .pnlBlogContainer {
            margin-top: 20px;
            padding: 10px;
            overflow-y: scroll;
     
        }
        .content {
            height: 850px;
            margin:0;
            display : flex;
            justify-content: center;
    }
        .col-sm-8 {
            width:100%;
        }
        .cboSort{
            
            display: inline-flex;
            justify-content:space-between;
        }
        .btnSort{
            border-top-right-radius: 0px;
            border-bottom-right-radius: 0px;
        }
        .btnSearch ,.btnSort{
            width: fit-content;
        }
        .input-group{
            width: 300px;
        }
        .jumbotron{
            background-image: url(Resources/grapes.jpg);
            background-color: rgba(255,255,255,0.5);
            background-blend-mode: lighten;
        }
    </style>
</asp:Content>
