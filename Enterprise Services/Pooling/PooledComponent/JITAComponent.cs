namespace PooledComponent
{
    using System;
    using System.EnterpriseServices;
    using System.Runtime.InteropServices;

    [JustInTimeActivation]
    [EventTrackingEnabled]
    [ProgId("JITAComponent")]
    public class JITAComponent : ServicedComponent, IDateComponent
    {
        private DateTime currentDate;

        public JITAComponent() : base() 
        {
            currentDate = DateTime.Now;
        }

        [AutoComplete]
        public DateTime GetDateTime()
        {
            return currentDate;
        }

        protected override void Activate()
        {
            base.Activate();
        }

        protected override void Deactivate()
        {
            base.Deactivate();
        }
    }
}
