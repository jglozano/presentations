namespace SecurityDemo
{
    using System;
    using System.EnterpriseServices;
    using System.Runtime.InteropServices;

    [ComVisible(true)]
    [ComponentAccessControl]
    [SecureMethod]
    public class SecuredComponent : ServicedComponent, ISecuredComponent
    {
        #region ISecuredComponent Members

        public int Add(int x, int y)
        {
            return x + y;
        }

        #endregion
    }

    [ComVisible(true)]
    public interface ISecuredComponent
    {
        int Add(int x, int y);
    }
}
