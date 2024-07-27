using UserManagementSystem.Models.Dtos.BaseDtos;

namespace UserManagementSystem.Services.Interfaces
{
    public interface IUserRefreshTokenService
    {
       
            Task<UserRefreshTokenDto> GetByUserIdAsync(string userId);
            Task<UserRefreshTokenDto> GetByUserFromRefreshToken(string refreshToken);
            Task AddAsync(UserRefreshTokenDto userRefreshToken);
            Task RemoveByUserIdAsync(string userId);
            Task UpdateAsync(UserRefreshTokenDto userRefreshToken);
        
    }

}
