using System.ComponentModel.DataAnnotations;

namespace Krishna.Services.ProductAPI.Models.Dto
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string CatogoryName { get; set; }
        public string ImageUrl { get; set; }
    }
}
