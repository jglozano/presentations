<%@ import namespace="System.Collections.Generic" %>

<%@ page language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<script runat="server">
    public void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            MovieRepository repo = new MovieRepository();

            MediaList.DataSource = repo.GetAllMovies();
            MediaList.DataBind();
        }
    }

    protected void MediaList_SelectedIndexChanged(object sender, EventArgs e)
    {
        string url = MediaList.SelectedValue;

        if (!string.IsNullOrEmpty(url))
        {
            Media1.MediaUrl = url;
        }
    }
    
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Drag and Drop Demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <h2>
        I LOVE DRAG AND DROP!!</h2>
    <asp:scriptmanager id="ScriptManager1" runat="server" />
    <div>
    </div>
    <asp:dropdownlist runat="server" id="MediaList" autopostback="true" datatextfield="Name"
        datavaluefield="Url" onselectedindexchanged="MediaList_SelectedIndexChanged" />
    <br />
    <asp:media id="Media1" runat="server" height="588px" mediaskin="Professional" mediaurl=""
        width="772px" />
    </form>
</body>
</html>
