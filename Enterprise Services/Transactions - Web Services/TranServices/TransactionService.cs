namespace TranServices
{
    using System;
    using System.EnterpriseServices;
    using System.Runtime.InteropServices;

    [ComVisible(true)]
    [Transaction]
    public class TransactionService : ServicedComponent, ITransactionalDateService
    {
        #region ITransactionalDateService Members

        [AutoComplete]
        public string GetTransactionId()
        {
            return ContextUtil.TransactionId.ToString();
        }

        [AutoComplete]
        public DateTime GetDateTime()
        {
            return DateTime.Now;
        }

        #endregion
    }

    [ComVisible(true)]
    public interface ITransactionalDateService
    {
        string GetTransactionId();

        DateTime GetDateTime();
    }
}
