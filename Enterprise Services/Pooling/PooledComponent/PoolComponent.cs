
namespace PooledComponent
{
    using System;
    using System.EnterpriseServices;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    [ObjectPooling(MinPoolSize = 2, MaxPoolSize = 4)]
    [EventTrackingEnabled]
    [ProgId("ObjectPoolComponent")]
    public class PoolComponent : ServicedComponent, IDateComponent
    {
        private DateTime currentDate;

        public PoolComponent()
        {
            currentDate = DateTime.Now;
        }

        public DateTime GetDateTime()
        {
            return currentDate;
        }

        protected override bool CanBePooled()
        {
            MessageBox.Show("I can be pooled!");
            return true;
        }
    }
}