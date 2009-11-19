// © 2005 IDesign Inc. All rights reserved 
//Questions? Comments? go to 
//http://www.idesign.net

namespace BankAccountServer
{
    using System;
    using System.Data.SqlClient;
    using System.EnterpriseServices;
    using System.Runtime.InteropServices;

    [Transaction(TransactionOption.Required)]
    [ComVisible(true)]
    public class Account : ServicedComponent, IAccount
    {
        SqlCommand m_SelectCommand;
        SqlCommand m_UpdateCommand;
        SqlConnection m_Connection;
        SqlDataAdapter m_Adapter;
        AccountsDataSet m_AccountsDataSet;

        public Account()
        {
            InitDataSource();
            m_Adapter.Fill(m_AccountsDataSet, "BankAccounts");
        }

        private void InitDataSource()
        {
            m_SelectCommand = new SqlCommand();
            m_UpdateCommand = new SqlCommand();
            m_Connection = new SqlConnection();
            m_Adapter = new SqlDataAdapter();
            m_AccountsDataSet = new AccountsDataSet();
            ((System.ComponentModel.ISupportInitialize)(m_AccountsDataSet)).BeginInit();

            // m_SelectCommand
            m_SelectCommand.CommandText = "SELECT Number, Balance, Name FROM dbo.BankAccounts";
            m_SelectCommand.Connection = m_Connection;

            // m_UpdateCommand
            m_UpdateCommand.CommandText = @"UPDATE dbo.BankAccounts SET Number = @Number, Balance = @Balance, Name = @Name WHERE (Number = @Original_Number) AND (Balance = @Original_Balance OR @Original_Balance1 IS NULL AND Balance IS NULL) AND (Name = @Original_Name OR @Original_Name1 IS NULL AND Name IS NULL); SELECT Number, Balance, Name FROM dbo.BankAccounts WHERE (Number = @Select_Number)";
            m_UpdateCommand.Connection = m_Connection;
            m_UpdateCommand.Parameters.Add(new SqlParameter("@Number", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Number", System.Data.DataRowVersion.Current, null));
            m_UpdateCommand.Parameters.Add(new SqlParameter("@Balance", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, true, ((System.Byte)(0)), ((System.Byte)(0)), "Balance", System.Data.DataRowVersion.Current, null));
            m_UpdateCommand.Parameters.Add(new SqlParameter("@Name", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, true, ((System.Byte)(0)), ((System.Byte)(0)), "Name", System.Data.DataRowVersion.Current, null));
            m_UpdateCommand.Parameters.Add(new SqlParameter("@Original_Number", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Number", System.Data.DataRowVersion.Original, null));
            m_UpdateCommand.Parameters.Add(new SqlParameter("@Original_Balance", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, true, ((System.Byte)(0)), ((System.Byte)(0)), "Balance", System.Data.DataRowVersion.Original, null));
            m_UpdateCommand.Parameters.Add(new SqlParameter("@Original_Balance1", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, true, ((System.Byte)(0)), ((System.Byte)(0)), "Balance", System.Data.DataRowVersion.Original, null));
            m_UpdateCommand.Parameters.Add(new SqlParameter("@Original_Name", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, true, ((System.Byte)(0)), ((System.Byte)(0)), "Name", System.Data.DataRowVersion.Original, null));
            m_UpdateCommand.Parameters.Add(new SqlParameter("@Original_Name1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, true, ((System.Byte)(0)), ((System.Byte)(0)), "Name", System.Data.DataRowVersion.Original, null));
            m_UpdateCommand.Parameters.Add(new SqlParameter("@Select_Number", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Number", System.Data.DataRowVersion.Current, null));

            // m_Connection
            m_Connection.ConnectionString = "data source=(local);initial catalog=Bank Account System;integrated security=SSPI;per" +
                "sist security info=True;workstation id=(local);packet size=4096";

            // m_Adapter
            m_Adapter.SelectCommand = m_SelectCommand;
            m_Adapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																							  new System.Data.Common.DataTableMapping("Table", "BankAccounts", new System.Data.Common.DataColumnMapping[] {
																																																			  new System.Data.Common.DataColumnMapping("Number", "Number"),
																																																			  new System.Data.Common.DataColumnMapping("Balance", "Balance"),
																																																			  new System.Data.Common.DataColumnMapping("Name", "Name")})});
            m_Adapter.UpdateCommand = m_UpdateCommand;

            // m_AccountsDataSet
            m_AccountsDataSet.DataSetName = "AccountsDataSet";
            m_AccountsDataSet.Locale = new System.Globalization.CultureInfo("en-US");
            m_AccountsDataSet.Namespace = "http://www.tempuri.org/AccountsDataSet.xsd";
        }

        [AutoComplete]
        public void Credit(int accountNumber, decimal amount)
        {
            AccountsDataSet.BankAccountsDataTable accounts = m_AccountsDataSet.BankAccounts;
            AccountsDataSet.BankAccountsRow account = accounts.FindByNumber(accountNumber);
            account.Balance += amount;

            m_Adapter.Update(accounts);
        }

        [AutoComplete]
        public void Debit(int accountNumber, decimal amount)
        {
            AccountsDataSet.BankAccountsDataTable accounts = m_AccountsDataSet.BankAccounts;
            AccountsDataSet.BankAccountsRow account = accounts.FindByNumber(accountNumber);

            if (account.Balance >= amount)
            {
                account.Balance -= amount;
            }
            else
            {
                throw new InvalidOperationException("Debit amount is greater than balance in account #" + accountNumber);
            }

            m_Adapter.Update(accounts);
        }
    }
}