namespace LCEDemo
{
    using System;
    using System.Windows.Forms;
    using System.EnterpriseServices;
    using System.Runtime.InteropServices;

    [ComVisible(true)]
    public class DateSubscriber : ServicedComponent, IDateEvent
    {
        public DateSubscriber() : base() {}

        #region IDateEvent Members

        public void OnShowDate()
        {
            string msg = "From " + GetType().FullName + " the current date is " + DateTime.Now.ToString();
            MessageBox.Show(msg, "LCE Demo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion
    }
}