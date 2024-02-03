using DataAccess.Models;

namespace DataAccess.Data
{
    public interface IProductData
    {
        Task AddNewProduct(ProductPOS productPOS);
        Task<IEnumerable<ProductPOS>> GetAllProduct();
        Task<IEnumerable<ProductData>> GetProductByKeyWord(string specifickeyword);
        Task<ProductPOS?> GetProductDetailById(int Id);
        Task<ProductData?> GetProductDetailById(string name);
        Task RemoveProduct(int productID);
        Task UpdateProduct(ProductPOS productPOS);
        Task UpdateProductPrice(int productid, decimal newprice);
    }
}