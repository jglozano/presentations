<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<string>" %>
<pre><%=  Html.Encode(Model.Replace("\t", "    ")) %></pre>
