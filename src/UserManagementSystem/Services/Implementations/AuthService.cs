using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using UserManagementSystem.Models.Dtos.BaseDtos;
using UserManagementSystem.Models.Dtos.LoginDtos;
using UserManagementSystem.Models.Dtos.RegisterDtos;
using UserManagementSystem.Models.Entities;
using UserManagementSystem.Models.IdentityConfig;
using UserManagementSystem.Services.Interfaces;

namespace UserManagementSystem.Services.Implementations
{
    public class AuthService : IAuthService
    {
        private readonly List<ClientDto> _clients;
        private readonly ITokenService _tokenService;
        private readonly CustomUserManager _userManager;
        private readonly SignInManager<FupiUser> _signInManager;
        private readonly IUnitOfWorkService _unitOfWork;
        private readonly IUserRefreshTokenService _userRefreshTokenService;


        public AuthService(IOptions<List<ClientDto>> optionsClient, ITokenService tokenService, CustomUserManager userManager, IUnitOfWorkService unitOfWork, IUserRefreshTokenService userRefreshTokenService, SignInManager<FupiUser> signInManager)
        {
            _clients = optionsClient.Value;
            _signInManager = signInManager;
            _tokenService = tokenService;
            _userManager = userManager;
            _unitOfWork = unitOfWork;
            _userRefreshTokenService = userRefreshTokenService;
        }

        public async Task<ResponseDto<TokenDto>> CreateTokenAsync(LoginDto loginDto)
        {
            if (loginDto == null) throw new ArgumentNullException(nameof(loginDto));

            var user = await _userManager.FindByEmailAsync(loginDto.Email);
            if (user == null) return ResponseDto<TokenDto>.Fail("Email or Password is wrong", 400, true);

            var signInResult = await _signInManager.PasswordSignInAsync(user, loginDto.Password, loginDto.RememberMe, true);
            if (signInResult.IsLockedOut)
            {
                return ResponseDto<TokenDto>.Fail("You can't log in for 3 minutes.", 400, true);

            }

            if (!await _userManager.CheckPasswordAsync(user, loginDto.Password))
            {
                return ResponseDto<TokenDto>.Fail("Email or Password is wrong", 400, true);
            }

            //if (!user.EmailConfirmed)
            //{
            //    return ResponseDto<TokenDto>.Fail("Email is not confirmed", 400, true);
            //}


            var token = _tokenService.CreateToken(user);


            var userRefreshToken = await _userRefreshTokenService.GetByUserIdAsync( user.Id );

            if (userRefreshToken == null)
            {
                await _userRefreshTokenService.AddAsync(new UserRefreshTokenDto { UserId = user.Id, Code = token.RefreshToken, Expiration = token.RefreshTokenExpiration });
            }
            else
            {
                userRefreshToken.Code = token.RefreshToken;
                userRefreshToken.Expiration = token.RefreshTokenExpiration;
            }

            await _unitOfWork.CommitAsync();

            return ResponseDto<TokenDto>.Success(token, 200);
        }
        
        public async Task<ResponseDto<NoDataDto>> RegisterAsync(RegisterDto registerDto)
        {
            // 1. Yeni bir kullanıcı oluşturun
            var newUser = new FupiUser
            {
                UserName = registerDto.Email,
                Email = registerDto.Email
                // Diğer kullanıcı bilgileri eklenebilir
            };

            var result = await _userManager.CreateAsync(newUser, registerDto.Password);

            if (!result.Succeeded)
            {
                // Kullanıcı oluşturma başarısız oldu, hata mesajlarını işleyin ve ResponseDto'yu başarısız olarak döndürün
                var errors = result.Errors.Select(e => e.Description).ToList();
                return ResponseDto<NoDataDto>.Fail(errors, 500);
            }

            // 2. Kullanıcıya rol atama gibi ek işlemler yapılabilir
            // Örneğin:
            // await _userManager.AddToRoleAsync(newUser, "User");

            // 3. Birim işlemini kaydet (UnitOfWork kullanımı örneği)
            await _unitOfWork.CommitAsync();

            // Başarılı yanıt döndürün
            return ResponseDto<NoDataDto>.Success(200);
        }

        public ResponseDto<ClientTokenDto> CreateTokenByClient(ClientLoginDto clientLoginDto)
        {
            var client = _clients.SingleOrDefault(x => x.Id == clientLoginDto.ClientId && x.Secret == clientLoginDto.ClientSecret);

            if (client == null)
            {
                return ResponseDto<ClientTokenDto>.Fail("ClientId or ClientSecret not found", 404, true);
            }

            var token = _tokenService.CreateTokenByClient(client);

            return ResponseDto<ClientTokenDto>.Success(token, 200);
        }

        public async Task<ResponseDto<TokenDto>> CreateTokenByRefreshToken(string refreshToken)
        {
            var existRefreshToken = await _userRefreshTokenService.GetByUserIdAsync(refreshToken);

            if (existRefreshToken == null)
            {
                return ResponseDto<TokenDto>.Fail("Refresh token not found", 404, true);
            }

            var user = await _userManager.FindByIdAsync(existRefreshToken.UserId);

            if (user == null)
            {
                return ResponseDto<TokenDto>.Fail("User Id not found", 404, true);
            }

            var tokenDto = _tokenService.CreateToken(user);

            existRefreshToken.Code = tokenDto.RefreshToken;
            existRefreshToken.Expiration = tokenDto.RefreshTokenExpiration;

            await _unitOfWork.CommitAsync();

            return ResponseDto<TokenDto>.Success(tokenDto, 200);
        }

        public async Task<ResponseDto<NoDataDto>> RevokeRefreshToken(string refreshToken)
        {
            var existRefreshToken = await _userRefreshTokenService.GetByUserFromRefreshToken( refreshToken);
            if (existRefreshToken == null)
            {
                return ResponseDto<NoDataDto>.Fail("Refresh token not found", 404, true);
            }

            _userRefreshTokenService.RemoveByUserIdAsync(existRefreshToken.UserId);

            await _unitOfWork.CommitAsync();

            return ResponseDto<NoDataDto>.Success(200);
        }
    }
}
