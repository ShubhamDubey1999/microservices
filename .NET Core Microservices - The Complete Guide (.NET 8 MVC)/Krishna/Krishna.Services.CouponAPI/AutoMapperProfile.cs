using AutoMapper;
using Krishna.Services.CouponAPI.Models;

namespace Krishna.Services.CouponAPI
{
    //public class AutoMapperProfile : Profile
    //{
    //    public AutoMapperProfile()
    //    { // ALSO WE CAN DO IT LIKE THIS by inheriting profile and createMap() under constructor
    //        CreateMap<Coupon, CouponDto>();
    //    }
    //}
    public class AutoMapperProfile
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Coupon,CouponDto>();
                config.CreateMap<CouponDto,Coupon>();
            });
            return mappingConfig;
        }
    }
}
