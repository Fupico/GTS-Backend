using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UserManagementSystem.Models.Dtos.BaseDtos;
using UserManagementSystem.Models.Dtos.LoginDtos;
using UserManagementSystem.Models.Dtos.RegisterDtos;
using UserManagementSystem.Services.Interfaces;

namespace UserManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IAuthService _authService) : CustomizedController
    {
        //private readonly IAuthService _authService = authService;

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            var result = await _authService.CreateTokenAsync(loginDto);

            return ActionResultInstance(result);
        }

        [HttpPost("Login-Client")]
        public IActionResult CreateTokenByClient(ClientLoginDto clientLoginDto)
        {
            var result = _authService.CreateTokenByClient(clientLoginDto);

            return ActionResultInstance(result);
        }

        [HttpPost("Login-WithRefreshToken")]
        public async Task<IActionResult> RevokeRefreshToken(RefreshTokenDto refreshTokenDto)
        {
            var result = await _authService.RevokeRefreshToken(refreshTokenDto.Token);

            return ActionResultInstance(result);
        }

        [HttpPost("Create-RefreshToken")]
        public async Task<IActionResult> CreateTokenByRefreshToken(RefreshTokenDto refreshTokenDto)

        {
            var result = await _authService.CreateTokenByRefreshToken(refreshTokenDto.Token);

            return ActionResultInstance(result);
        }
        
        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterDto register)

        {
            var result = await _authService.RegisterAsync(register);

            return ActionResultInstance(result);
        }

        [Authorize]
        [HttpPost("Test")]
        public string Test()
        {
            return "Test --> Succesfully";
        }
    }
}
