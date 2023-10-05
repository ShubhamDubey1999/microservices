using Krishna.Web.Models;
using Krishna.Web.Service.IService;
using Krishna.Web.Utility;

namespace Krishna.Web.Service
{
    public class ProductService : IProductService
    {
        private readonly IBaseService _baseService;
        public ProductService(IBaseService baseService)
        {
            _baseService = baseService;
        }
        public async Task<ResponseDto?> CreateProductsAsync(ProductDto obj)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = SD.ApiType.POST,
                Data = obj,
                Url = SD.ProductApiBase + "/api/product"
            });
        }

        public async Task<ResponseDto?> DeleteProductsAsync(int Id)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = SD.ApiType.DELETE,
                Url = SD.ProductApiBase + "/api/product/" + Id
            });
        }

        public async Task<ResponseDto?> GetAllProductAsync()
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = SD.ApiType.GET,
                Url = SD.ProductApiBase + "/api/product"
            });
        }

        public async Task<ResponseDto?> GetProductAsync(string CouponCode)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = SD.ApiType.GET,
                Url = SD.ProductApiBase + "/api/product/GetByCode/" + CouponCode
            });
        }

        public async Task<ResponseDto?> GetProductByIdAsync(int Id)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = SD.ApiType.GET,
                Url = SD.ProductApiBase + "/api/product/" + Id
            });
        }

        public async Task<ResponseDto?> UpdateProductsAsync(ProductDto obj)
        {
            return await _baseService.SendAsync(new RequestDto
            {
                ApiType = SD.ApiType.PUT,
                Data = obj,
                Url = SD.ProductApiBase + "/api/product"
            });
        }
    }
}
