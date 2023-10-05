using Krishna.Services.ShoppingCart.Models.Dto;

namespace Krishna.Services.ShoppingCart.Service.IService
{
    public interface ICouponService
    {
        Task<CouponDto> GetCoupon(string couponCode);
    }
}
