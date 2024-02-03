CREATE PROCEDURE [dbo].[sp_getAllProducts]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Id, ProductId, Name, Price, PriceUnit, Category, Description, StockQuantity, StockUnit
    FROM [dbo].[ProductPOS];
END;
