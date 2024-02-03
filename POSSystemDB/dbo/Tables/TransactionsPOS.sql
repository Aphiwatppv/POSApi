CREATE TABLE [dbo].[TransactionsPOS]
(
    TransactionId INT IDENTITY(1,1) PRIMARY KEY,
    TransactionDate DATETIME,
    TotalAmount DECIMAL(18, 2),
    PaymentMethod NVARCHAR(100),
    MemberId INT NULL,
    FOREIGN KEY (MemberId) REFERENCES [dbo].[MemberPOS](MemberId)
)
