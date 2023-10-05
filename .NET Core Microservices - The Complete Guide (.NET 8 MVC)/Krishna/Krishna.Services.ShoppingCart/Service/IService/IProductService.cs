using Krishna.Services.ShoppingCart.Models.Dto;
namespace Krishna.Services.ShoppingCart.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
