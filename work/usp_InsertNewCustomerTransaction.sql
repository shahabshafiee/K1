USE [KeyvanCRM]
GO
/****** Object:  StoredProcedure [dbo].[usp_InsertNewCustomerTransaction]    Script Date: 10/19/2007 16:39:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Shahab
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[usp_InsertNewCustomerTransaction] 
	-- Add the parameters for the stored procedure here
	@CustomerID int , 
	@Debit money , 
	@Credit money , 
	@Comment text 
AS
BEGIN
	declare @ThisBalance money
	declare @LastBalance money
	declare @Balance money
	set @ThisBalance=@Debit-@Credit
	if not exists (select * from CustomerTransaction where CustomerID=@CustomerID)
	begin
		set @LastBalance=0
	end
	else
	begin
		set @LastBalance=(select top 1 Balance from CustomerTransaction where CustomerID=@CustomerID order by TransactionID desc)
	end
	set @Balance=@ThisBalance+@LastBalance
	if (@Credit!=0)
	begin
		update Customer set LastPaymentdate=getdate()
		where CustomerID=@CustomerID
	end
	insert into CustomerTransaction(CustomerID,Debit,Credit,Balance,Comment,TransactionDate)
	values(@CustomerID,@Debit,@Credit,@Balance,@Comment,getdate())

	update Customer set Balance=@Balance
	where CustomerID=@CustomerID
END
