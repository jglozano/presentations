<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

<h3>About this example</h3>

<% Html.Telerik().TabStrip()
		.Name("code-viewer-tabs")
		.Items(tabstrip => 
        {
			bool hasDescription = !string.IsNullOrEmpty(ViewData.Get<string>("Description"));
			if (hasDescription)
			{
				tabstrip.Add()
					.Text("Description")
					.Content(() =>
					{
                        %>
						    <div class="description"><%= ViewData["Description"] %></div>
					    <%
                    });
			}

			var codeFiles = ViewData.Get<Dictionary<string, string>>("codeFiles");

            foreach (var codeFile in codeFiles)
			{
                tabstrip.Add()
                        .Text(codeFile.Key)
                        .LoadContentFrom("CodeFile", "Home", new { file = codeFile.Value });
			}
		})
		.SelectedIndex(0)
		.ClientEvents(c => c.OnSelect("codeTabSelect"))
		.Render(); 
%>
<% Html.Telerik().ScriptRegistrar().OnDocumentReady(() =>
    { 
           %>
                codeTabLoad();
           <%
    }); 
%>