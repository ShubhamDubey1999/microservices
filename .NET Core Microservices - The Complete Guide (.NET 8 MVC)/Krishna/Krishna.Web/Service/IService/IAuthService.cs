using Krishna.Web.Models;

namespace Krishna.Web.Service.IService
{
    public interface IAuthService
    {
        Task<ResponseDto?> LoginAsyc(LoginRequestDto loginRequestDto);
        Task<ResponseDto?> RegisterAsyc(RegistrationRequestDto registrationRequestDto);
        Task<ResponseDto?> AssignRoleAsyc(RegistrationRequestDto registrationRequestDto);
    }
}
