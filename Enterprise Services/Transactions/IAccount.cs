// © 2005 IDesign Inc. All rights reserved 
//Questions? Comments? go to 
//http://www.idesign.net

namespace BankAccountServer
{
    using System;
    using System.Runtime.InteropServices;

    [ComVisible(true)]
    public interface IAccount
    {
        void Credit(int accountNumber, decimal amount);
        void Debit(int accountNumber, decimal amount);
    }
}
