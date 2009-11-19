try
{
    var cmp = new ActiveXObject("Demo.BasicService");

    if (cmp != null)
    {
        var message = cmp.GetMessage();
        
        WScript.Echo(message);
        cmp.Dispose();
    }
}
catch(e)
{
    WScript.Echo(e.description);
}
