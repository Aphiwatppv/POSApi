using System.Runtime.CompilerServices;

namespace POSApi;

public static class API
{
    public static void ConfigurationAPI(this WebApplication app)
    {
        // Mapping Endpoint of API // Get, Post , Put ,Delete Base URL then Endpoint
        app.MapGet(pattern: "/GetAllProduct",GetAllProduct);
        app.MapGet(pattern: "/GetProductDetailsById/{Id}", GetProductDetailsById);
        app.MapGet(pattern: "/GetProductDetailsByName/{Name}", GetProductDetailsByName);
    }
    private static async Task<IResult> GetAllProduct(IProductData productData)
    {
     
        try
        {
            return Results.Ok(await productData.GetAllProduct());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }

    }

    private static async Task<IResult> GetProductDetailsById(IProductData productData , int Id)
    {
        try
        {
            return Results.Ok(await productData.GetProductDetailById(Id));
        }
        catch(Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetProductDetailsByName(IProductData productData, string name)
    {
        try
        {
            return Results.Ok(await productData.GetProductDetailByName(name));
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

}
