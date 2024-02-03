CREATE PROCEDURE [dbo].[sp_getProductDetailsById]
    @ProductId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT * FROM [dbo].[ProductPOS] WHERE ProductId = @ProductId;
END;