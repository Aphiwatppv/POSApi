CREATE TABLE [dbo].[TransactionItemPOS]
(
    TransactionItemId INT IDENTITY(1,1) PRIMARY KEY,
    TransactionId INT,
    ProductId INT,
    Price DECIMAL(18, 2),
    Quantity INT,
    FOREIGN KEY (TransactionId) REFERENCES [dbo].[TransactionsPOS](TransactionId),
    FOREIGN KEY (ProductId) REFERENCES [dbo].[ProductPOS](ProductId)
)