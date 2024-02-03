CREATE PROCEDURE [dbo].[sp_updateProduct]
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

    UPDATE [dbo].[ProductPOS]
    SET Name = @Name,
        Price = @Price,
        PriceUnit = @PriceUnit,
        Category = @Category,
        Description = @Description,
        StockQuantity = @StockQuantity,
        StockUnit = @StockUnit
    WHERE ProductId = @ProductId;
END;
