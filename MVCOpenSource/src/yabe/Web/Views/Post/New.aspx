<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" AutoEventWireup="true"
    Inherits="System.Web.Mvc.ViewPage<IEnumerable<Mvc.Models.Category.CategoryViewModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <form method="post" action='<%=Url.Action("Create") %>'>
        <fieldset>
            <legend>Create New Post</legend>
            <table>
                <tr valign="top">
                    <td>
                        <label for="title">
                            Title:</label>
                    </td>
                    <td>
                        <%=Html.TextBox("title", string.Empty, new {length = 80, size = 80})%>
                    </td>
                </tr>
                <tr valign="top">
                    <td>
                        <label for="abstract">
                            Contents:</label>
                    </td>
                    <td>
                        <%=Html.TextArea("contents", "",4,79,new{})%>
                    </td>
                </tr>
                <tr valign="top">
                    <td>
                        <label for="abstract">
                            Category:</label>
                    </td>
                    <td>
                        <%=Html.ListBox("categories", new MultiSelectList(Model, "Id", "Name"))%>
                    </td>
                </tr>
                <tr valign="top">
                    <td colspan="2">
                        <div class="button-row">
                            <input type="submit" id="Create" value="Create Post" />
                        </div>
                    </td>
                </tr>
            </table>
        </fieldset>
        </form>
    </div>
</asp:Content>
