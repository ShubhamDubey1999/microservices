using Krishna.Web.Models;

namespace Krishna.Web.Service.IService
{
    public interface IBaseService
    {
        Task<ResponseDto?> SendAsync(RequestDto requestDto,bool withBearer=true);
    }
}
