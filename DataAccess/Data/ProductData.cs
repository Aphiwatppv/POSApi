using DataAccess.DatabaseAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data;

public class ProductData : IProductData
{
    ISqlDataAccess _dataAccess;
    public ProductData(ISqlDataAccess dataAccess)
    {
        _dataAccess = dataAccess;

    }
    #region Loading Method 
    //This is an enire methods for Loading data from DB (ProductPOS Table) 
    public async Task<IEnumerable<ProductPOS>> GetAllProduct() =>
       await _dataAccess.LoadData<ProductPOS, dynamic>(storedProcedure: "", new { });
    public async Task<ProductPOS?> GetProductDetailById(int Id)
    {
        var Result = await _dataAccess.LoadData<ProductPOS, dynamic>(storedProcedure: "", new { ProductId = Id });
        return Result.FirstOrDefault();
    }
    public async Task<ProductData?> GetProductDetailById(string name)
    {
        var Result = await _dataAccess.LoadData<ProductData, dynamic>(storedProcedure: "", new { Name = name });
        return Result.FirstOrDefault();
    }
    public async Task<IEnumerable<ProductData>> GetProductByKeyWord(string specifickeyword) =>
        await _dataAccess.LoadData<ProductData, dynamic>(storedProcedure: "", new { Name = specifickeyword });
    #endregion
    #region SavingMethod
    // This is an entire methods for Saving data to DB (ProductPOS Table)
    public async Task AddNewProduct(ProductPOS productPOS) =>
        await _dataAccess.SaveData(storedProcedure: "", new
        {
            productPOS.ProductId,
            productPOS.Name,
            productPOS.Price,
            productPOS.PriceUnit,
            productPOS.Category,
            productPOS.Description,
            productPOS.StockQuantity,
            productPOS.StockUnit
        });
    public async Task RemoveProduct(int productID) =>
        await _dataAccess.SaveData(storedProcedure: "", new { ProductId = productID });
    public async Task UpdateProduct(ProductPOS productPOS) =>
        await _dataAccess.SaveData(storedProcedure: "", new
        {
            productPOS.ProductId,
            productPOS.Name,
            productPOS.Price,
            productPOS.PriceUnit,
            productPOS.Category,
            productPOS.Description,
            productPOS.StockQuantity,
            productPOS.StockUnit
        });
    public async Task UpdateProductPrice(int productid, decimal newprice) =>
        await _dataAccess.SaveData(storedProcedure: "", new { ProductId = productid, NewPrice = newprice });
    #endregion

















}

