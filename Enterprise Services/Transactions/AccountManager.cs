// © 2005 IDesign Inc. All rights reserved 
//Questions? Comments? go to 
//http://www.idesign.net

namespace BankAccountServer
{
    using System;
    using System.EnterpriseServices;
    using System.Runtime.InteropServices;

    [Transaction]
    [ComVisible(true)]
    public class AccountManager : ServicedComponent, IAccountManager
    {
        public AccountManager() : base() {}

        [AutoComplete]
        public void Transfer(int debitAccountNumber, int creditAccountNumber, decimal amount)
        {
            IAccount creditAccount = new Account();
            IAccount debitAccount = new Account();

            creditAccount.Credit(creditAccountNumber, amount);
            debitAccount.Debit(debitAccountNumber, amount);
        }
    }
}
