<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" AutoEventWireup="true"
    Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <form method="post" action='<%=Url.Action("create")%>'>
        <fieldset>
            <legend>Create New Category</legend>
            <table>
                <tr>
                    <td>
                        <label for="title">
                            Name:</label>
                    </td>
                    <td>
                        <%=Html.TextBox("Name") %>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label for="abstract">
                            Description:</label>
                    </td>
                    <td>
                        <%=Html.TextArea("Description", "",4,79,new{})%>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <div class="button-row">
                            <input type="submit" id="Create" value="Create Category" />
                        </div>
                    </td>
                </tr>
            </table>
        </fieldset>
        </form>
    </div>
</asp:Content>
