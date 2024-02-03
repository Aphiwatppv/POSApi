CREATE PROCEDURE [dbo].[sp_updateProductPrice]
    @ProductId INT,
    @NewPrice DECIMAL(18, 2)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE [dbo].[ProductPOS]
    SET Price = @NewPrice
    WHERE ProductId = @ProductId;
END;