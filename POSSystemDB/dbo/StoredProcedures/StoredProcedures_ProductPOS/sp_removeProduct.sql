CREATE PROCEDURE [dbo].[sp_removeProduct]
    @ProductId INT
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM [dbo].[ProductPOS] WHERE ProductId = @ProductId;
END;