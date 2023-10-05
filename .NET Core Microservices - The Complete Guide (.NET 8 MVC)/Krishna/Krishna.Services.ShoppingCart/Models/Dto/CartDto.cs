using Krishna.Services.ShoppingCart.Models.Dto;

namespace Krishna.Services.ShoppingCart.Models.Dto
{
    public class CartDto
    {
        public CartHeaderDto CartHeader { get; set; }
        public IEnumerable<CartDetailsDto>? CartDetails { get; set; }
    }
}