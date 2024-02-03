CREATE PROCEDURE [dbo].[sp_getProductDetailsByName]
    @Name NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT * FROM [dbo].[ProductPOS] WHERE Name = @Name;
END;