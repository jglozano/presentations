// © 2005 IDesign Inc. All rights reserved 
//Questions? Comments? go to 
//http://www.idesign.net

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using BankAccountServer;


namespace TransactionClient
{
    public class BankClient : Form
    {
        Button m_TransferButton;
        TextBox m_SourceBox;
        Label m_SourceLabel;
        Label m_DestLabel;
        TextBox m_DestBox;
        TextBox m_AmountBox;
        Label m_AmountLabel;
        DataGrid m_AccountsGrid;
        SqlCommand m_SelectCommand;
        SqlCommand m_InsertCommand;
        SqlCommand m_UpdateCommand;
        SqlCommand m_DeleteCommand;
        SqlConnection m_Connection;
        SqlDataAdapter m_Adapter;
        PictureBox m_PictureBox;
        AccountsDataSet m_AccountsDataSet;

        public BankClient()
        {
            InitializeComponent();
            m_Adapter.Fill(m_AccountsDataSet);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        void InitializeComponent()
        {
            this.m_AmountBox = new System.Windows.Forms.TextBox();
            this.m_DestLabel = new System.Windows.Forms.Label();
            this.m_TransferButton = new System.Windows.Forms.Button();
            this.m_Connection = new System.Data.SqlClient.SqlConnection();
            this.m_SelectCommand = new System.Data.SqlClient.SqlCommand();
            this.m_DestBox = new System.Windows.Forms.TextBox();
            this.m_SourceLabel = new System.Windows.Forms.Label();
            this.m_AccountsDataSet = new AccountsDataSet();
            this.m_InsertCommand = new System.Data.SqlClient.SqlCommand();
            this.m_DeleteCommand = new System.Data.SqlClient.SqlCommand();
            this.m_AmountLabel = new System.Windows.Forms.Label();
            this.m_AccountsGrid = new System.Windows.Forms.DataGrid();
            this.m_UpdateCommand = new System.Data.SqlClient.SqlCommand();
            this.m_Adapter = new System.Data.SqlClient.SqlDataAdapter();
            this.m_SourceBox = new System.Windows.Forms.TextBox();
            this.m_PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_AccountsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_AccountsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // m_AmountBox
            // 
            this.m_AmountBox.Location = new System.Drawing.Point(272, 40);
            this.m_AmountBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.m_AmountBox.Name = "m_AmountBox";
            this.m_AmountBox.Size = new System.Drawing.Size(80, 20);
            this.m_AmountBox.TabIndex = 2;
            this.m_AmountBox.Text = "100";
            // 
            // m_DestLabel
            // 
            this.m_DestLabel.Location = new System.Drawing.Point(144, 16);
            this.m_DestLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.m_DestLabel.Name = "m_DestLabel";
            this.m_DestLabel.Size = new System.Drawing.Size(104, 23);
            this.m_DestLabel.TabIndex = 3;
            this.m_DestLabel.Text = "Destination Acount:";
            // 
            // m_TransferButton
            // 
            this.m_TransferButton.Location = new System.Drawing.Point(392, 40);
            this.m_TransferButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.m_TransferButton.Name = "m_TransferButton";
            this.m_TransferButton.TabIndex = 1;
            this.m_TransferButton.Text = "Transfer";
            this.m_TransferButton.Click += new System.EventHandler(this.OnTransfer);
            // 
            // m_Connection
            // 
            this.m_Connection.ConnectionString = "data source=localhost;initial catalog=Bank Account System;integrated security=SSP" +
                "I;persist security info=False;workstation id=localhost;packet size=4096";
            this.m_Connection.FireInfoMessageEventOnUserErrors = false;
            // 
            // m_SelectCommand
            // 
            this.m_SelectCommand.CommandText = "SELECT Number, Balance, Name FROM dbo.BankAccounts";
            this.m_SelectCommand.Connection = this.m_Connection;
            // 
            // m_DestBox
            // 
            this.m_DestBox.Location = new System.Drawing.Point(144, 40);
            this.m_DestBox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.m_DestBox.Name = "m_DestBox";
            this.m_DestBox.TabIndex = 2;
            this.m_DestBox.Text = "456";
            // 
            // m_SourceLabel
            // 
            this.m_SourceLabel.Location = new System.Drawing.Point(8, 16);
            this.m_SourceLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.m_SourceLabel.Name = "m_SourceLabel";
            this.m_SourceLabel.TabIndex = 3;
            this.m_SourceLabel.Text = "Source Acount:";
            // 
            // m_AccountsDataSet
            // 
            this.m_AccountsDataSet.DataSetName = "AccountsDataSet";
            this.m_AccountsDataSet.Locale = new System.Globalization.CultureInfo("en-US");
            this.m_AccountsDataSet.RemotingFormat = System.Data.SerializationFormat.Xml;
            // 
            // m_InsertCommand
            // 
            this.m_InsertCommand.CommandText = "INSERT INTO dbo.BankAccounts(Number, Balance, Name) VALUES (@Number, @Balance, @N" +
                "ame); SELECT Number, Balance, Name FROM dbo.BankAccounts WHERE (Number = @Select" +
                "_Number)";
            this.m_InsertCommand.Connection = this.m_Connection;
            this.m_InsertCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Number", System.Data.SqlDbType.Int, 4, "Number"),
            new System.Data.SqlClient.SqlParameter("@Balance", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, true, ((byte)(0)), ((byte)(0)), "Balance", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, true, ((byte)(0)), ((byte)(0)), "Name", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Select_Number", System.Data.SqlDbType.Int, 4, "Number")});
            // 
            // m_DeleteCommand
            // 
            this.m_DeleteCommand.CommandText = "DELETE FROM dbo.BankAccounts WHERE (Number = @Number) AND (Balance = @Balance OR " +
                "@Balance1 IS NULL AND Balance IS NULL) AND (Name = @Name OR @Name1 IS NULL AND N" +
                "ame IS NULL)";
            this.m_DeleteCommand.Connection = this.m_Connection;
            this.m_DeleteCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Number", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Number", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Balance", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, true, ((byte)(0)), ((byte)(0)), "Balance", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Balance1", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, true, ((byte)(0)), ((byte)(0)), "Balance", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, true, ((byte)(0)), ((byte)(0)), "Name", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Name1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, true, ((byte)(0)), ((byte)(0)), "Name", System.Data.DataRowVersion.Original, null)});
            // 
            // m_AmountLabel
            // 
            this.m_AmountLabel.Location = new System.Drawing.Point(272, 16);
            this.m_AmountLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.m_AmountLabel.Name = "m_AmountLabel";
            this.m_AmountLabel.Size = new System.Drawing.Size(192, 23);
            this.m_AmountLabel.TabIndex = 3;
            this.m_AmountLabel.Text = "Amount:";
            // 
            // m_AccountsGrid
            // 
            this.m_AccountsGrid.DataMember = "";
            this.m_AccountsGrid.DataSource = this.m_AccountsDataSet.BankAccounts;
            this.m_AccountsGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.m_AccountsGrid.Location = new System.Drawing.Point(8, 104);
            this.m_AccountsGrid.Name = "m_AccountsGrid";
            this.m_AccountsGrid.Size = new System.Drawing.Size(264, 216);
            this.m_AccountsGrid.TabIndex = 4;
            // 
            // m_UpdateCommand
            // 
            this.m_UpdateCommand.CommandText = @"UPDATE dbo.BankAccounts SET Number = @Number, Balance = @Balance, Name = @Name WHERE (Number = @Original_Number) AND (Balance = @Original_Balance OR @Original_Balance1 IS NULL AND Balance IS NULL) AND (Name = @Original_Name OR @Original_Name1 IS NULL AND Name IS NULL); SELECT Number, Balance, Name FROM dbo.BankAccounts WHERE (Number = @Select_Number)";
            this.m_UpdateCommand.Connection = this.m_Connection;
            this.m_UpdateCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Number", System.Data.SqlDbType.Int, 4, "Number"),
            new System.Data.SqlClient.SqlParameter("@Balance", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, true, ((byte)(0)), ((byte)(0)), "Balance", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, true, ((byte)(0)), ((byte)(0)), "Name", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Original_Number", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Number", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Balance", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, true, ((byte)(0)), ((byte)(0)), "Balance", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Balance1", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, true, ((byte)(0)), ((byte)(0)), "Balance", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Name", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, true, ((byte)(0)), ((byte)(0)), "Name", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Name1", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, true, ((byte)(0)), ((byte)(0)), "Name", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Select_Number", System.Data.SqlDbType.Int, 4, "Number")});
            // 
            // m_Adapter
            // 
            this.m_Adapter.DeleteCommand = this.m_DeleteCommand;
            this.m_Adapter.InsertCommand = this.m_InsertCommand;
            this.m_Adapter.SelectCommand = this.m_SelectCommand;
            this.m_Adapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "BankAccounts", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Number", "Number"),
                        new System.Data.Common.DataColumnMapping("Balance", "Balance"),
                        new System.Data.Common.DataColumnMapping("Name", "Name")})});
            this.m_Adapter.UpdateCommand = this.m_UpdateCommand;
            // 
            // m_SourceBox
            // 
            this.m_SourceBox.Location = new System.Drawing.Point(8, 40);
            this.m_SourceBox.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.m_SourceBox.Name = "m_SourceBox";
            this.m_SourceBox.TabIndex = 2;
            this.m_SourceBox.Text = "123";
            // 
            // m_PictureBox
            // 
            this.m_PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_PictureBox.Location = new System.Drawing.Point(319, 104);
            this.m_PictureBox.Name = "m_PictureBox";
            this.m_PictureBox.Size = new System.Drawing.Size(145, 131);
            this.m_PictureBox.TabIndex = 5;
            this.m_PictureBox.TabStop = false;
            m_PictureBox.Image = new Bitmap(typeof(BankClient), "Money.bmp");

            // 
            // BankClient
            // 

            this.ClientSize = new System.Drawing.Size(504, 333);
            this.Controls.Add(this.m_PictureBox);
            this.Controls.Add(this.m_AccountsGrid);
            this.Controls.Add(this.m_SourceLabel);
            this.Controls.Add(this.m_SourceBox);
            this.Controls.Add(this.m_TransferButton);
            this.Controls.Add(this.m_DestLabel);
            this.Controls.Add(this.m_DestBox);
            this.Controls.Add(this.m_AmountBox);
            this.Controls.Add(this.m_AmountLabel);
            this.Name = "BankClient";
            this.Text = "Bank Client";
            ((System.ComponentModel.ISupportInitialize)(this.m_AccountsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_AccountsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new BankClient());
        }

        void OnTransfer(object sender, EventArgs e)
        {
            int debitAccount;
            int creditAccount;
            decimal amount;

            debitAccount = Convert.ToInt32(m_SourceBox.Text);
            creditAccount = Convert.ToInt32(m_DestBox.Text);
            amount = Convert.ToDecimal(m_AmountBox.Text);
            try
            {
                IAccountManager accountManager;
                accountManager = new AccountManager();
                accountManager.Transfer(debitAccount, creditAccount, amount);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Some error occurred: " + exception.Message, "Bank Client");
            }
            finally
            {
                m_AccountsDataSet.Clear();
                m_Adapter.Fill(m_AccountsDataSet);
                m_AccountsGrid.Refresh();
            }
        }
    }
}
