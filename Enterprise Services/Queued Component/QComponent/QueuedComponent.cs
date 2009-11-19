namespace QueueDemo
{
    using System;
    using System.EnterpriseServices;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    [InterfaceQueuing]
    [ComVisible(true)]
    public interface IDateInterface
    {
        void ShowDateTime();
    }

    [ComVisible(true)]
    public class QueuedComponent : ServicedComponent, IDateInterface
    {
        public QueuedComponent() : base() {}

        public void ShowDateTime()
        {
            MessageBox.Show("Executing call at " + DateTime.Now.ToString(), "Queued Date");
        }
    }
}
