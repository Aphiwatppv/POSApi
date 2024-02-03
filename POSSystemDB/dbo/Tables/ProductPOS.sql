CREATE TABLE [dbo].[ProductPOS]
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    ProductId INT UNIQUE,
    Name NVARCHAR(255),
    Price DECIMAL(18, 2),
    PriceUnit NVARCHAR(50),
    Category NVARCHAR(255),
    Description NVARCHAR(MAX),
    StockQuantity INT,
    StockUnit NVARCHAR(50)
)
