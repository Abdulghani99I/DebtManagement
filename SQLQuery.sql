USE [DebtManagement]
GO
/****** Object:  UserDefinedFunction [dbo].[RemainingDebtToClientInDinars]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE FUNCTION [dbo].[RemainingDebtToClientInDinars] 
(
	@ClientID int
)
RETURNS Numeric(11,2)
AS
BEGIN

	DECLARE @Amount Numeric(11,2);

    SELECT @Amount = ISNULL((SELECT SUM(Amount) FROM ClientsDebt WHERE ClientID = @ClientID), 0) - 
    ISNULL((SELECT SUM(Amount) FROM ClientsPayments WHERE ClientID = @ClientID), 0)

	-- Return the result of the function
	RETURN @Amount
END
GO
/****** Object:  UserDefinedFunction [dbo].[RemainingDebtToSupplierInDinars]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE FUNCTION [dbo].[RemainingDebtToSupplierInDinars] 
(
	@SupplierID int
)
RETURNS Numeric(11,2)
AS
BEGIN

	DECLARE @Amount Numeric(11,2);

    SELECT @Amount = ISNULL((SELECT SUM(Amount) FROM SuppliersDebt WHERE SupplierID = @SupplierID), 0) - 
    ISNULL((SELECT SUM(Amount) FROM SuppliersPayments WHERE SupplierID = @SupplierID), 0)

	-- Return the result of the function
	RETURN @Amount
END
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[ClientID] [int] IDENTITY(1,1) NOT NULL,
	[PersonID] [int] NOT NULL,
	[BalanceDinar] [numeric](11, 2) NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClientsDebt]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientsDebt](
	[DebtMenuID] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [int] NOT NULL,
	[PersonID] [int] NOT NULL,
	[MenuName] [nvarchar](150) NOT NULL,
	[Amount] [numeric](11, 2) NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
 CONSTRAINT [PK_ClinetsMenu] PRIMARY KEY CLUSTERED 
(
	[DebtMenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClientsPayments]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientsPayments](
	[PaymentID] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [int] NOT NULL,
	[Amount] [numeric](11, 2) NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
 CONSTRAINT [PK_PymentClients] PRIMARY KEY CLUSTERED 
(
	[PaymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[People]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[People](
	[PersonID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](100) NOT NULL,
	[Phone] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_People] PRIMARY KEY CLUSTERED 
(
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[SupplierID] [int] IDENTITY(1,1) NOT NULL,
	[PersonID] [int] NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SuppliersDebt]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SuppliersDebt](
	[DebtMenuID] [int] IDENTITY(1,1) NOT NULL,
	[SupplierID] [int] NOT NULL,
	[PersonID] [int] NOT NULL,
	[MenuName] [nvarchar](150) NOT NULL,
	[Amount] [numeric](11, 2) NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
 CONSTRAINT [PK_SuppliersMenu] PRIMARY KEY CLUSTERED 
(
	[DebtMenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SuppliersPayments]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SuppliersPayments](
	[PaymentID] [int] IDENTITY(1,1) NOT NULL,
	[SupplierID] [int] NOT NULL,
	[Amount] [numeric](11, 2) NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
 CONSTRAINT [PK_PymentSuppliers] PRIMARY KEY CLUSTERED 
(
	[PaymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](20) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[IsManager] [bit] NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsersSettings]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsersSettings](
	[SettingsID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](100) NOT NULL,
	[CompanyDescription] [nvarchar](500) NULL,
	[CompanyPicture] [nvarchar](max) NULL,
	[ConversionValue] [int] NOT NULL,
 CONSTRAINT [PK_UsersSettings] PRIMARY KEY CLUSTERED 
(
	[SettingsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Clients] ADD  CONSTRAINT [DF_Clients_BalanceDinar]  DEFAULT ((0)) FOR [BalanceDinar]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_IsManager]  DEFAULT ((1)) FOR [IsManager]
GO
ALTER TABLE [dbo].[Clients]  WITH CHECK ADD  CONSTRAINT [FK_Clients_People] FOREIGN KEY([PersonID])
REFERENCES [dbo].[People] ([PersonID])
GO
ALTER TABLE [dbo].[Clients] CHECK CONSTRAINT [FK_Clients_People]
GO
ALTER TABLE [dbo].[ClientsDebt]  WITH CHECK ADD  CONSTRAINT [FK_ClinetsMenu_Clients] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Clients] ([ClientID])
GO
ALTER TABLE [dbo].[ClientsDebt] CHECK CONSTRAINT [FK_ClinetsMenu_Clients]
GO
ALTER TABLE [dbo].[ClientsPayments]  WITH CHECK ADD  CONSTRAINT [FK_ClientsPayments_Clients] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Clients] ([ClientID])
GO
ALTER TABLE [dbo].[ClientsPayments] CHECK CONSTRAINT [FK_ClientsPayments_Clients]
GO
ALTER TABLE [dbo].[Suppliers]  WITH CHECK ADD  CONSTRAINT [FK_Suppliers_People] FOREIGN KEY([PersonID])
REFERENCES [dbo].[People] ([PersonID])
GO
ALTER TABLE [dbo].[Suppliers] CHECK CONSTRAINT [FK_Suppliers_People]
GO
ALTER TABLE [dbo].[SuppliersDebt]  WITH CHECK ADD  CONSTRAINT [FK_SuppliersMenu_Suppliers] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Suppliers] ([SupplierID])
GO
ALTER TABLE [dbo].[SuppliersDebt] CHECK CONSTRAINT [FK_SuppliersMenu_Suppliers]
GO
ALTER TABLE [dbo].[SuppliersPayments]  WITH CHECK ADD  CONSTRAINT [FK_SuppliersPayments_Suppliers] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Suppliers] ([SupplierID])
GO
ALTER TABLE [dbo].[SuppliersPayments] CHECK CONSTRAINT [FK_SuppliersPayments_Suppliers]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Users]
GO
/****** Object:  StoredProcedure [dbo].[AddClient]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[AddClient]
@FullName nvarchar(50),
@Address nvarchar(100),
@Phone nvarchar(15)
as
begin


insert into People(FullName, Address, Phone)
values
(@FullName, @Address, @Phone)

DECLARE @PersonID int = SCOPE_IDENTITY();

insert into Clients (PersonID, CreatedAt)
values
(@PersonID, GETDATE())

return SCOPE_IDENTITY();

end



GO
/****** Object:  StoredProcedure [dbo].[AddClientDebtMenu]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[AddClientDebtMenu]
@ClientID int,
@MenuName nvarchar(150),
@Amount numeric(11,2)
as

begin
	Declare @PersonID int;
	
	-- Set PersonID By Using ClientID.
	Select @PersonID = PersonID from Clients
	where ClientID = @ClientID;

	insert into ClientsDebt (ClientID, PersonID, MenuName, Amount, CreatedAt)
	values (@ClientID, @PersonID, @MenuName, @Amount, GETDATE())

	return SCOPE_IDENTITY();
end
GO
/****** Object:  StoredProcedure [dbo].[AddClientPayment]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[AddClientPayment]
@ClientID int,
@Amount numeric(11,2)
as
begin
	insert into ClientsPayments (ClientID, Amount, CreatedAt)
	values(@ClientID, @Amount, GETDATE())
End


select * from ClientsPayments
GO
/****** Object:  StoredProcedure [dbo].[AddClientsDebtMenu]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[AddClientsDebtMenu]
@ClientID int,
@MenuName nvarchar(150),
@Amount numeric(11,2)
as

begin
	Declare @PersonID int;
	
	-- Set PersonID By Using ClientID.
	Select @PersonID = PersonID from Clients
	where ClientID = @ClientID;

	insert into ClientsDebt (ClientID, PersonID, MenuName, Amount, CreatedAt)
	values (@ClientID, @PersonID, @MenuName, @Amount, GETDATE())

	return SCOPE_IDENTITY();
end
GO
/****** Object:  StoredProcedure [dbo].[AddSupplier]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE Procedure [dbo].[AddSupplier]
@FullName nvarchar(50),
@Address nvarchar(100),
@Phone nvarchar(15)
as
begin


insert into People(FullName, Address, Phone)
values
(@FullName, @Address, @Phone)

DECLARE @PersonID int = SCOPE_IDENTITY();

insert into Suppliers (PersonID, CreatedAt)
values
(@PersonID, GETDATE())

return SCOPE_IDENTITY();

end
GO
/****** Object:  StoredProcedure [dbo].[AddSupplierDebtMenu]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[AddSupplierDebtMenu]
@SupplierID int,
@MenuName nvarchar(150),
@Amount numeric(11,2)
as

begin
	Declare @PersonID int;
	
	-- Set PersonID By Using SupplierID.
	Select @PersonID = PersonID from Suppliers
	where SupplierID = @SupplierID;

	insert into SuppliersDebt (SupplierID, PersonID, MenuName, Amount, CreatedAt)
	values (@SupplierID, @PersonID, @MenuName, @Amount, GETDATE())

	return SCOPE_IDENTITY();
end
GO
/****** Object:  StoredProcedure [dbo].[AddSupplierPayment]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[AddSupplierPayment]
@SupplierID int,
@Amount numeric(11,2)
as
begin
	insert into SuppliersPayments (SupplierID, Amount, CreatedAt)
	values(@SupplierID, @Amount, GETDATE())
End


select * from SuppliersPayments
GO
/****** Object:  StoredProcedure [dbo].[AddUser]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[AddUser]
@FullName nvarchar(50),
@UserName nvarchar(20),
@Password nvarchar(50),
@isManager bit
as

begin
	insert into Users (FullName, UserName, Password, isManager,  CreatedAt)
	values (@FullName, @UserName, @Password, @isManager, GETDATE());

	return SCOPE_IDENTITY();
End
GO
/****** Object:  StoredProcedure [dbo].[BackupCurrentDatabase]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[BackupCurrentDatabase]
    @BackupFolderPath NVARCHAR(255) -- Path of the folder where the backup will be stored
AS
BEGIN
    SET NOCOUNT ON;

    -- Get the name of the current database
    DECLARE @DatabaseName NVARCHAR(255) = 'DebtManagement'; 

    -- Validate folder path ends with a backslash
    IF RIGHT(@BackupFolderPath, 1) <> '\'
        SET @BackupFolderPath = @BackupFolderPath + '\';

    -- Generate backup file name with timestamp
    DECLARE @BackupFileName NVARCHAR(500);
    SET @BackupFileName = @BackupFolderPath + @DatabaseName + '_' + 
                          FORMAT(GETDATE(), 'yyyyMMdd_HHmmss') + '.bak';

    BEGIN TRY
        -- Perform the backup
        BACKUP DATABASE @DatabaseName 
        TO DISK = @BackupFileName
        WITH INIT, NAME = 'Database Full Backup';

        PRINT 'Backup successful. File: ' + @BackupFileName;
    END TRY
    BEGIN CATCH
        -- Handle errors
        PRINT 'Error occurred during the backup.';
        PRINT ERROR_MESSAGE();
    END CATCH
END;




GO
/****** Object:  StoredProcedure [dbo].[DeleteClientByID]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[DeleteClientByID]
	@ClientID int
AS
begin
	declare @PersonID int;

	-- Set PersonID Before Delete Supplier.
	select @PersonID = PersonID 
	from Clients 
	where ClientID = @ClientID;

	delete Clients
	where ClientID = @ClientID;

	delete People
	where People.PersonID = @PersonID;
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteClientDebtByDebtMenuID]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[DeleteClientDebtByDebtMenuID]
@DebtMenuID int
as 
begin
	delete ClientsDebt
	where ClientsDebt.DebtMenuID = @DebtMenuID;
End

GO
/****** Object:  StoredProcedure [dbo].[DeleteClientPaymentByPaymentID]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[DeleteClientPaymentByPaymentID]
@PaymentID int
as
begin

	delete ClientsPayments
	where PaymentID = @PaymentID;

end

GO
/****** Object:  StoredProcedure [dbo].[DeleteSupplierByID]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DeleteSupplierByID]
	@SupplierID int
AS
begin
	declare @PersonID int;

	-- Set PersonID Before Delete Supplier.
	select @PersonID = PersonID 
	from Suppliers 
	where SupplierID = @SupplierID;

	delete Suppliers
	where Suppliers.SupplierID = @SupplierID;

	delete People
	where People.PersonID = @PersonID;
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteSupplierDebtByDebtMenuID]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[DeleteSupplierDebtByDebtMenuID]
@DebtMenuID int
as 
begin
	delete SuppliersDebt
	where DebtMenuID = @DebtMenuID;
End

GO
/****** Object:  StoredProcedure [dbo].[DeleteSupplierPaymentByPaymentID]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[DeleteSupplierPaymentByPaymentID]
@PaymentID int
as
begin

	delete SuppliersPayments
	where PaymentID = @PaymentID;

end

GO
/****** Object:  StoredProcedure [dbo].[DeleteUserByUserID]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[DeleteUserByUserID]
@UserID int
as
Begin
	delete Users
	where Users.UserID = @UserID;
end
GO
/****** Object:  StoredProcedure [dbo].[FindClient]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE Procedure [dbo].[FindClient]
@ClientID int,
@PersonID int output,
@BalanceDinar numeric(11,2) output,
@CreatedAt DateTime output 
as
begin
	
	select 
	@PersonID = PersonID,
	@BalanceDinar = dbo.RemainingDebtToClientInDinars(@ClientID),
	@CreatedAt = CreatedAt
	from Clients
	where Clients.ClientID = @ClientID;
End
GO
/****** Object:  StoredProcedure [dbo].[FindClientDebtMenuByDebtMenuID]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[FindClientDebtMenuByDebtMenuID]
@DebtMenuID int,
@MenuName nvarchar(150) output,
@Amount numeric(11,2) output
as
begin
	select @MenuName = MenuName, @Amount = Amount from ClientsDebt
	where DebtMenuID = @DebtMenuID;
End
GO
/****** Object:  StoredProcedure [dbo].[FindClientPaymentByPaymentID]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[FindClientPaymentByPaymentID]
@PaymentID int,
@Amount numeric(11,2) output
as
begin
	select @Amount = Amount from ClientsPayments
	where PaymentID = @PaymentID;
End
GO
/****** Object:  StoredProcedure [dbo].[FindPerson]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


Create Procedure [dbo].[FindPerson]
@PersonID int,
@FullName nvarchar(50) output,
@Address nvarchar(100) output,
@Phone nvarchar(15) output
as
begin
	
	select 
	@FullName = FullName,
	@Address = Address,
	@Phone = Phone
	from People
	where PersonID = @PersonID;
End
GO
/****** Object:  StoredProcedure [dbo].[FindSupplier]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE Procedure [dbo].[FindSupplier]
@SupplierID int,
@PersonID int output,
@BalanceDinar numeric(11,2) output,
@CreatedAt DateTime output 
as
begin
	
	select 
	@PersonID = PersonID,
	@BalanceDinar = dbo.RemainingDebtToSupplierInDinars(@SupplierID),
	@CreatedAt = CreatedAt
	from Suppliers
	where Suppliers.SupplierID = @SupplierID;
End
GO
/****** Object:  StoredProcedure [dbo].[FindSupplierDebtMenuByDebtMenuID]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[FindSupplierDebtMenuByDebtMenuID]
@DebtMenuID int,
@MenuName nvarchar(150) output,
@Amount numeric(11,2) output
as
begin
	
	
	select @MenuName = MenuName, @Amount = Amount from SuppliersDebt
	where DebtMenuID = @DebtMenuID;
End
GO
/****** Object:  StoredProcedure [dbo].[FindSupplierPaymentByPaymentID]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[FindSupplierPaymentByPaymentID]
@PaymentID int,
@Amount numeric(11,2) output
as
begin
	select @Amount = Amount from SuppliersPayments
	where PaymentID = @PaymentID;
End
GO
/****** Object:  StoredProcedure [dbo].[FindUserByUserID]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[FindUserByUserID]
@UserID int,
@UserName nvarchar(20) output,
@FullName nvarchar(50) output,
@Password nvarchar(50) output,
@isManager bit output
as
begin
	select 
	@UserName = UserName,
	@FullName = FullName,
	@Password = Password,
	@isManager = IsManager
	from Users
	where @UserID = UserID;
end
GO
/****** Object:  StoredProcedure [dbo].[FindUserByUserName]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[FindUserByUserName]
@UserName nvarchar(20),
@UserID int output,
@FullName nvarchar(50) output,
@Password nvarchar(50) output,
@isManager bit output
as
begin
	
	select 
	@UserID = UserID,
	@FullName = FullName,
	@Password = Password,
	@isManager = IsManager
	from Users
	where @UserName = UserName;
end
GO
/****** Object:  StoredProcedure [dbo].[GetAllClients]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[GetAllClients]
as
begin 
SELECT        Clients.ClientID, People.FullName,

dbo.RemainingDebtToClientInDinars(Clients.ClientID) as BalanceDinar,
(dbo.RemainingDebtToClientInDinars(Clients.ClientID) / (select UsersSettings.ConversionValue from UsersSettings)) as BalanceDollar,
People.Phone, People.Address, Clients.CreatedAt
FROM            
Clients
INNER JOIN
                         People ON People.PersonID = Clients.PersonID
						 
						 
END






GO
/****** Object:  StoredProcedure [dbo].[GetAllSuppliers]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllSuppliers]
AS
BEGIN 
    SELECT 
        Suppliers.SupplierID, 
        People.FullName,
        dbo.RemainingDebtToSupplierInDinars(Suppliers.SupplierID) AS BalanceDinar,
		(dbo.RemainingDebtToSupplierInDinars(Suppliers.SupplierID) / (select top 1 UsersSettings.ConversionValue from UsersSettings)) as BalanceDollar,

        People.Phone, 
        People.Address, 
        Suppliers.CreatedAt
    FROM 
		UsersSettings,
        Suppliers 
    INNER JOIN 
        People ON People.PersonID = Suppliers.PersonID
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllUsers]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[GetAllUsers]
as
begin
	
SELECT 
    UserID, 
    FullName, 
    UserName, 
    Password,
    CASE 
        WHEN IsManager = 1 THEN 'مدير'
        ELSE 'مستخدم'
    END AS UserType,
    CreatedAt
FROM Users;

end

GO
/****** Object:  StoredProcedure [dbo].[GetClientDebtByClientID]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[GetClientDebtByClientID]
@ClientID int
as
begin

SELECT        DebtMenuID, MenuName, Amount, CreatedAt
FROM            ClientsDebt
where ClientID = @ClientID
end
GO
/****** Object:  StoredProcedure [dbo].[GetClientPaymentsByClientID]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[GetClientPaymentsByClientID]
@ClientID int
as
begin
	select ClientsPayments.PaymentID, ClientsPayments.Amount, ClientsPayments.CreatedAt from ClientsPayments 
	where ClientsPayments.ClientID = @ClientID;
end




GO
/****** Object:  StoredProcedure [dbo].[GetSettings]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE Procedure [dbo].[GetSettings]
@SettingsUserID int output,
@CompanyName nvarchar(100) output,
@CompanyDescription nvarchar(500) output,
@PictureData nvarchar(Max) output,
@ConversionValue int output
as

begin
	SELECT      @SettingsUserID = UsersSettings.SettingsID,
				@CompanyName = UsersSettings.CompanyName,
				@CompanyDescription = UsersSettings.CompanyDescription,
				@PictureData = UsersSettings.CompanyPicture,
				@ConversionValue = UsersSettings.ConversionValue
	FROM        UsersSettings
End


GO
/****** Object:  StoredProcedure [dbo].[GetSupplierDebtBySupplierID]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetSupplierDebtBySupplierID]
@SupplierID int
as
begin

SELECT        DebtMenuID, MenuName, Amount, CreatedAt
FROM            SuppliersDebt
where SupplierID = @SupplierID
end
GO
/****** Object:  StoredProcedure [dbo].[GetSupplierPaymentsBySupplierID]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[GetSupplierPaymentsBySupplierID]
@SupplierID int
as
begin
	select PaymentID, SuppliersPayments.Amount, SuppliersPayments.CreatedAt from SuppliersPayments 
	where SupplierID = @SupplierID;


end






GO
/****** Object:  StoredProcedure [dbo].[ResetClientDebtAndPaymentsByClientID]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[ResetClientDebtAndPaymentsByClientID]
    @ClientID INT
AS
BEGIN
    -- Start the transaction
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Delete from ClientsPayments
        DELETE FROM ClientsPayments 
        WHERE ClientID = @ClientID;

        -- Delete from ClientsDebt
        DELETE FROM ClientsDebt
        WHERE ClientID = @ClientID;

        -- Commit the transaction if both deletes succeed
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Rollback the transaction if any error occurs
        ROLLBACK TRANSACTION;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[ResetSupplierDebtAndPaymentsBySupplierID]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ResetSupplierDebtAndPaymentsBySupplierID]
    @SupplierID INT
AS
BEGIN
    -- Start the transaction
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Delete from SuppliersPayments
        DELETE FROM SuppliersPayments 
        WHERE SupplierID = @SupplierID;

        -- Delete from SuppliersDebt
        DELETE FROM SuppliersDebt
        WHERE SupplierID = @SupplierID;

        -- Commit the transaction if both deletes succeed
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Rollback the transaction if any error occurs
        ROLLBACK TRANSACTION;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[RestoreDatabase]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[RestoreDatabase]
@PathFile NVARCHAR(255)
AS
BEGIN
    -- تغيير قاعدة البيانات إلى وضع أحادي المستخدم وإغلاق أي جلسات أخرى
    ALTER DATABASE [DebtManagement] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    

    -- استعادة قاعدة البيانات من النسخة الاحتياطية
    RESTORE DATABASE [DebtManagement]
    FROM DISK = @PathFile
    WITH REPLACE;
    

    -- إعادة قاعدة البيانات إلى الوضع متعدد المستخدمين بعد الاستعادة
    ALTER DATABASE [DebtManagement] SET MULTI_USER;
    
END
GO
/****** Object:  StoredProcedure [dbo].[TotalClientsDebt]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[TotalClientsDebt]
as
begin
	select Sum(Amount) from ClientsDebt;
End
GO
/****** Object:  StoredProcedure [dbo].[TotalClientsPayments]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[TotalClientsPayments]
as
begin
	select Sum(Amount) from ClientsPayments;
End
GO
/****** Object:  StoredProcedure [dbo].[TotalSuppliersDebt]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[TotalSuppliersDebt]
as
begin
	select Sum(Amount) from SuppliersDebt
End



GO
/****** Object:  StoredProcedure [dbo].[TotalSuppliersPayments]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[TotalSuppliersPayments]
as
begin
	select Sum(Amount) from SuppliersPayments;
End
GO
/****** Object:  StoredProcedure [dbo].[UpdateClient]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[UpdateClient]
	@ClientID int,
	@FullName nvarchar(50),
	@Address nvarchar(100),
	@Phone nvarchar(15)
AS

UPDATE People
SET 
    People.FullName = @FullName,   
    People.Address = @Address,     
    People.Phone = @Phone          
FROM 
    People
INNER JOIN 
    Clients ON People.PersonID = Clients.PersonID
WHERE 
    Clients.ClientID = @ClientID;



RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[UpdateClientDebtMenu]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[UpdateClientDebtMenu]
@DebtMenuID int,
@MenuName nvarchar(150),
@Amount numeric(11,2)
as
begin
	update ClientsDebt
	set MenuName = @MenuName,
	Amount = @Amount
	where DebtMenuID = @DebtMenuID;
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateClientPayment]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[UpdateClientPayment]
@PaymentID int,
@Amount numeric(11,2)
as
begin

UPDATE ClientsPayments
   SET Amount = @Amount
 WHERE ClientsPayments.PaymentID = @PaymentID;

end
GO
/****** Object:  StoredProcedure [dbo].[UpdateSettings]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[UpdateSettings]
@CompanyName nvarchar(100),
@CompanyDescription nvarchar(500),
@PictureData nvarchar(Max),
@ConversionValue int
as

begin

	Declare @SettingsID int = (select top 1 UsersSettings.SettingsID  from UsersSettings);

	update UsersSettings set 
	CompanyName = @CompanyName,
	CompanyDescription = @CompanyDescription,
	CompanyPicture = @PictureData,
	ConversionValue = @ConversionValue
	where SettingsID = @SettingsID;
End
GO
/****** Object:  StoredProcedure [dbo].[UpdateSupplier]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[UpdateSupplier]
	@SupplierID int,
	@FullName nvarchar(50),
	@Address nvarchar(100),
	@Phone nvarchar(15)
AS

UPDATE People
SET 
    People.FullName = @FullName,   
    People.Address = @Address,     
    People.Phone = @Phone          
FROM 
    People
INNER JOIN 
    Suppliers ON People.PersonID = Suppliers.PersonID
WHERE 
    Suppliers.SupplierID = @SupplierID;



RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[UpdateSupplierDebtMenu]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[UpdateSupplierDebtMenu]
@DebtMenuID int,
@MenuName nvarchar(150),
@Amount numeric(11,2)
as
begin
	update SuppliersDebt
	set MenuName = @MenuName,
	Amount = @Amount
	where DebtMenuID = @DebtMenuID;
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateSupplierPayment]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[UpdateSupplierPayment]
@PaymentID int,
@Amount numeric(11,2)
as
begin

UPDATE SuppliersPayments
   SET Amount = @Amount
 WHERE SuppliersPayments.PaymentID = @PaymentID;

end
GO
/****** Object:  StoredProcedure [dbo].[UpdateUserByUserID]    Script Date: 11/21/2024 7:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[UpdateUserByUserID]
@UserID int,
@FullName nvarchar(50),
@UserName nvarchar(20),
@Password nvarchar(50),
@isManager bit
as

begin
	update Users set
	FullName = @FullName,
	UserName = @UserName,
	Password = @Password,
	IsManager = @isManager

	where UserID = @UserID;

End
GO
