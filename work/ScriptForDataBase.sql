/*
 *ER/Studio 7.0 SQL Code Generation
 * Company :      MySelf
 * Project :      DATA MODEL
 * Author :       Kamal
 *
 * Date Created : Friday, October 19, 2007 15:23:42
 * Target DBMS : Microsoft SQL Server 2005
 */

/* 
 * TABLE: Customer 
 */

CREATE TABLE Customer(
    CustomerID          int             IDENTITY(1,1),
    CustomerStatusID    int             NULL,
    Code                varchar(20)     NOT NULL,
    FirstName           varchar(50)     NOT NULL,
    LastName            varchar(50)     NOT NULL,
    Telephone           varchar(50)     NOT NULL,
    Introducer          varchar(100)    NOT NULL,
    Address             text            NOT NULL,
    Balance             money           CONSTRAINT [DF_Customer_Balance] DEFAULT ((0)) NOT NULL,
    CONSTRAINT PK_Customer PRIMARY KEY NONCLUSTERED (CustomerID)
)
go



IF OBJECT_ID('Customer') IS NOT NULL
    PRINT '<<< CREATED TABLE Customer >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE Customer >>>'
go

/* 
 * TABLE: CustomerStatus 
 */

CREATE TABLE CustomerStatus(
    CustomerStatusID      int            IDENTITY(1,1),
    CustomerStatusName    varchar(18)    NOT NULL,
    CONSTRAINT PK_CustomerStatus PRIMARY KEY NONCLUSTERED (CustomerStatusID)
)
go



IF OBJECT_ID('CustomerStatus') IS NOT NULL
    PRINT '<<< CREATED TABLE CustomerStatus >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE CustomerStatus >>>'
go

/* 
 * TABLE: CustomerTransaction 
 */

CREATE TABLE CustomerTransaction(
    TransactionID      int         IDENTITY(1,1),
    CustomerID         int         NOT NULL,
    Debit              money       NOT NULL,
    Credit             money       NOT NULL,
    Balance            money       NOT NULL,
    Comment            text        NULL,
    TransactionDate    datetime    NOT NULL,
    CONSTRAINT PK_MoneyTransaction PRIMARY KEY NONCLUSTERED (TransactionID)
)
go



IF OBJECT_ID('CustomerTransaction') IS NOT NULL
    PRINT '<<< CREATED TABLE CustomerTransaction >>>'
ELSE
    PRINT '<<< FAILED CREATING TABLE CustomerTransaction >>>'
go

/* 
 * INDEX: FK_CustomerStatus_Customer 
 */

CREATE INDEX FK_CustomerStatus_Customer ON Customer(CustomerStatusID)
go
IF EXISTS (SELECT * FROM sysindexes WHERE id=OBJECT_ID('Customer') AND name='FK_CustomerStatus_Customer')
    PRINT '<<< CREATED INDEX Customer.FK_CustomerStatus_Customer >>>'
ELSE
    PRINT '<<< FAILED CREATING INDEX Customer.FK_CustomerStatus_Customer >>>'
go

/* 
 * INDEX: FK_Customer_MoneyTransaction 
 */

CREATE INDEX FK_Customer_MoneyTransaction ON CustomerTransaction(CustomerID)
go
IF EXISTS (SELECT * FROM sysindexes WHERE id=OBJECT_ID('CustomerTransaction') AND name='FK_Customer_MoneyTransaction')
    PRINT '<<< CREATED INDEX CustomerTransaction.FK_Customer_MoneyTransaction >>>'
ELSE
    PRINT '<<< FAILED CREATING INDEX CustomerTransaction.FK_Customer_MoneyTransaction >>>'
go

/* 
 * TABLE: Customer 
 */

ALTER TABLE Customer ADD CONSTRAINT FK_CustomerStatus_Customer 
    FOREIGN KEY (CustomerStatusID)
    REFERENCES CustomerStatus(CustomerStatusID)
go


/* 
 * TABLE: CustomerTransaction 
 */

ALTER TABLE CustomerTransaction ADD CONSTRAINT FK_Customer_MoneyTransaction 
    FOREIGN KEY (CustomerID)
    REFERENCES Customer(CustomerID)
go


