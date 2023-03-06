using Mango.Web.Models;

namespace Mango.Web.Services.IServices
{
    public interface IProductServices
    {
        Task<T> GetAllProductsAsync<T>();
        Task<T> GetProductByIdAsync<T>(int id);
        Task<T> CreateProductAsync<T>(ProductDto product);
        Task<T> UpdateProductAsync<T>(ProductDto productD);
        Task<T> DeleteProductAsync<T>(int id);

    }
}
