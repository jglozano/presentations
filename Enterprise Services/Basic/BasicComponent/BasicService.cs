namespace BasicComponent
{
    using System;
    using System.EnterpriseServices;
    using System.Runtime.InteropServices;
    
    [ProgId("Demo.BasicService")]
    public class BasicService : ServicedComponent, IBasicService
    {
        public string GetMessage()
        {
            string format = "Hello from the Enterprise Services world!\n\nMy host is {0}.";
            return string.Format(System.Globalization.CultureInfo.CurrentCulture, format,
                AppDomain.CurrentDomain.SetupInformation.ApplicationName);
        }
    }

    public interface IBasicService
    {
        string GetMessage();
    }
}
