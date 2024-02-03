using System.Runtime.CompilerServices;

namespace POSApi;

public static class API
{
    public static void ConfigurationAPI(this WebApplication app)
    {
        // Mapping Endpoint of API // Get, Post , Put ,Delete Base URL then Endpoint
        app.MapGet(pattern: "/GetAllProduct",GetAllProduct);
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

    //private static async Task<IResult> GetAllProduct(IProductData productData)
    //{
    //    return Results.Ok(await productData.GetAllProduct());
    //}

}
