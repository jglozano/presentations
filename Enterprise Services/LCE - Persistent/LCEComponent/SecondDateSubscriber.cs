namespace LCEDemo
{
    using System;
    using System.EnterpriseServices;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    [ComVisible(true)]
    public class SecondDateSubscriber : ServicedComponent, IDateEvent
    {
        #region IDateEvent Members

        public void OnShowDate()
        {
            string msg = "From " + GetType().FullName + " the current date is " + DateTime.Now.ToString();
            MessageBox.Show(msg, "LCE Demo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion
    }
}
