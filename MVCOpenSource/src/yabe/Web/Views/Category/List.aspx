<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" AutoEventWireup="true"
  Inherits="System.Web.Mvc.ViewPage<IEnumerable<Mvc.Models.Category.CategoryViewModel>>" %>

<%@ Import Namespace="Mvc.Models.Category" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  <p>
    <%=Html.ActionLink("Create New Category","new")%></p>
  <% if (Model != null && Model.Count() > 0) {  %>
      <% foreach (CategoryViewModel category in Model) { %>
      <div>
        <h3><%= category.Name %></h3>
        <span><%=category.Description %></span>
      </div>
     <% } %>
  <% } %>
</asp:Content>
