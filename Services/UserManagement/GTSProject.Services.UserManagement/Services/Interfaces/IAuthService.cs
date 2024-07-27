
using UserManagementSystem.Models.Dtos.BaseDtos;
using UserManagementSystem.Models.Dtos.LoginDtos;
using UserManagementSystem.Models.Dtos.RegisterDtos;

namespace UserManagementSystem.Services.Interfaces
{
    public interface IAuthService
    {
        Task<ResponseDto<TokenDto>> CreateTokenAsync(LoginDto loginDto);
        Task<ResponseDto<NoDataDto>> RegisterAsync(RegisterDto registerDto);

        Task<ResponseDto<TokenDto>> CreateTokenByRefreshToken(string refreshToken);

        Task<ResponseDto<NoDataDto>> RevokeRefreshToken(string refreshToken);

        ResponseDto<ClientTokenDto> CreateTokenByClient(ClientLoginDto clientLoginDto);
    }
}
