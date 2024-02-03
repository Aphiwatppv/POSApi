CREATE PROCEDURE [dbo].[sp_getProductsByKeyword]
    @Keyword NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT * FROM [dbo].[ProductPOS] 
    WHERE Name LIKE '%' + @Keyword + '%';
END;