use [master]
GO

IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'Bank Account System')
	DROP DATABASE [Bank Account System]
GO

DECLARE @device_directory NVARCHAR(520)
SELECT @device_directory = SUBSTRING(filename, 1, CHARINDEX(N'master.mdf', LOWER(filename)) - 1)
FROM master.dbo.sysaltfiles WHERE dbid = 1 AND fileid = 1
 
EXECUTE (N'CREATE DATABASE [Bank Account System]
  ON PRIMARY (NAME = N''Bank Account System'', FILENAME = N''' + @device_directory + N'Bank Account System.mdf'')
  LOG ON (NAME = N''Bank Account System_log'',  FILENAME = N''' + @device_directory + N'Bank Account System.ldf'')')
GO

exec sp_dboption N'Bank Account System', N'autoclose', N'false'
GO

exec sp_dboption N'Bank Account System', N'bulkcopy', N'false'
GO

exec sp_dboption N'Bank Account System', N'trunc. log', N'true'
GO

exec sp_dboption N'Bank Account System', N'torn page detection', N'true'
GO

exec sp_dboption N'Bank Account System', N'read only', N'false'
GO

exec sp_dboption N'Bank Account System', N'dbo use', N'false'
GO

exec sp_dboption N'Bank Account System', N'single', N'false'
GO

exec sp_dboption N'Bank Account System', N'autoshrink', N'true'
GO

exec sp_dboption N'Bank Account System', N'ANSI null default', N'false'
GO

exec sp_dboption N'Bank Account System', N'recursive triggers', N'false'
GO

exec sp_dboption N'Bank Account System', N'ANSI nulls', N'false'
GO

exec sp_dboption N'Bank Account System', N'concat null yields null', N'false'
GO

exec sp_dboption N'Bank Account System', N'cursor close on commit', N'false'
GO

exec sp_dboption N'Bank Account System', N'default to local cursor', N'false'
GO

exec sp_dboption N'Bank Account System', N'quoted identifier', N'false'
GO

exec sp_dboption N'Bank Account System', N'ANSI warnings', N'false'
GO

exec sp_dboption N'Bank Account System', N'auto create statistics', N'true'
GO

exec sp_dboption N'Bank Account System', N'auto update statistics', N'true'
GO

use [Bank Account System]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BankAccounts]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[BankAccounts]
GO

CREATE TABLE [dbo].[BankAccounts] (
	[Number] [int] NOT NULL ,
	[Balance] [money] NULL ,
	[Name] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[BankAccounts] WITH NOCHECK ADD 
	CONSTRAINT [PK_BankAccounts] PRIMARY KEY  CLUSTERED 
	(
		[Number]
	)  ON [PRIMARY] 
GO

INSERT INTO BankAccounts (Number, Balance, Name) Values (123,1000,'Juval')
INSERT INTO BankAccounts (Number, Balance, Name) Values (456, 1000, 'Brian')
GO
