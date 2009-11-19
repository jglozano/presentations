namespace LCEDemo
{
    using System;
    using System.EnterpriseServices;
    using System.Runtime.InteropServices;

    [ComVisible(true)]
    public interface IDateEvent
    {
        void OnShowDate();
    }

    [EventClass]
    [ComVisible(true)]
    public class DateEventClass : ServicedComponent, IDateEvent
    {
        public DateEventClass() : base() {}

        public void OnShowDate()
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }
}
