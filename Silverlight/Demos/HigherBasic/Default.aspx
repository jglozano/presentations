<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
          <Services>
            <asp:ServiceReference Path="~/scripts/Silverlight.js" />
            <asp:ServiceReference Path="~/scripts/defaultscript.js" />
          </Services>
          <Services>
          <asp:ServiceReference Path="~/WeatherService.asmx" />
          <asp:ServiceReference Path="~/ComplexService.asmx" />
          </Services>
        </asp:ScriptManager>               

        <div id="slControlHost">
        </div>

        <script type="text/javascript">
            Silverlight.createObject("Default.xaml",
        $get('slControlHost'), 
        "slControl",
                                 {
                                     width: '1024', 
                                 height:'530', 
                                 inplaceInstallPrompt:false, 
                                 background:'#00000000', 
                                 isWindowless:'true', framerate:'24', 
                                 version:'1.0'},
                                 {onError:null, onLoad:null},
                                 null);                                 
         </script>
    </form>
</body>
</html>
