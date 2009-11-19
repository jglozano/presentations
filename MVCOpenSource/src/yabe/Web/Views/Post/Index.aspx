<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" AutoEventWireup="true"
    Inherits="System.Web.Mvc.ViewPage<IEnumerable<Mvc.Models.Post.PostViewModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%
        var posts = Model;

        if (posts != null && posts.Count() > 0)
        { 
    %>
    <% foreach (var post in posts)
       {
    %>
    <div>
        <h3>
            <%= post.Title  %></h3>
        <span>
            <%=post.PostedDate %>
            -- Comments [<%=post.Comments.Count%>]</span>
        <div>
            <span>
                <%=post.Contents %></span>
        </div>
        <br />
        <span>Categories:
            <%foreach (var category in post.Categories)
              { %>
            <strong>
                <%=category.Name %></strong>&nbsp;&nbsp;
            <% } %>
        </span>
    </div>
    <% } %>
    <% } %>
</asp:Content>
