namespace BasicClient
{
    using System;
    using System.EnterpriseServices;

    using BasicComponent;

    class Program
    {
        static void Main(string[] args)
        {
            IBasicService svc = new BasicService();
            string message = svc.GetMessage();

            Console.WriteLine("Message from component/service: '{0}'", message);
            
            Console.Write("Press <ENTER> to exit.");
            Console.ReadLine();
        }
    }
}
