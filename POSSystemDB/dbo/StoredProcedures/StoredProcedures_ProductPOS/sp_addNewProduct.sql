CREATE PROCEDURE [dbo].[sp_addNewProduct]
    @ProductId INT,
    @Name NVARCHAR(255),
    @Price DECIMAL(18, 2),
    @PriceUnit NVARCHAR(50),
    @Category NVARCHAR(255),
    @Description NVARCHAR(MAX),
    @StockQuantity INT,
    @StockUnit NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO [dbo].[ProductPOS] (ProductId ,Name, Price, PriceUnit, Category, Description, StockQuantity, StockUnit)
    VALUES (@ProductId,@Name, @Price, @PriceUnit, @Category, @Description, @StockQuantity, @StockUnit);
END;