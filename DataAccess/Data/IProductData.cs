using DataAccess.Models;

namespace DataAccess.Data
{
    public interface IProductData
    {
        Task AddNewProduct(ProductPOS productPOS);
        Task<IEnumerable<ProductPOS>> GetAllProduct();
        Task<IEnumerable<ProductPOS>> GetProductByKeyWord(string specifickeyword);
        Task<ProductPOS?> GetProductDetailById(int Id);
        Task<ProductPOS?> GetProductDetailByName(string name);
        Task RemoveProduct(int productID);
        Task UpdateProduct(ProductPOS productPOS);
        Task UpdateProductPrice(int productid, decimal newprice);
    }
}