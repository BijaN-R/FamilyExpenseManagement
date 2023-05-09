using Application.DTO;

namespace Application.Services.Contracts
{
    public interface ILoginService
    {
        Task<LoginResponseDto> Login(LoginDto model);
        Task<RegisterResponseDto> Register(RegisterDto model);
    }
}