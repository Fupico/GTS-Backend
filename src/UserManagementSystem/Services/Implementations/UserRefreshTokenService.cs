using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Models.DbConfig;
using UserManagementSystem.Models.Dtos.BaseDtos;
using UserManagementSystem.Services.Interfaces;

namespace UserManagementSystem.Services.Implementations
{

    public class UserRefreshTokenService : IUserRefreshTokenService
    {
        private readonly FupiContext _context;

        public UserRefreshTokenService(FupiContext context)
        {
            _context = context;
        }

        public async Task<UserRefreshTokenDto> GetByUserIdAsync(string userId)
        {
            return await _context.UserRefreshTokens.SingleOrDefaultAsync(x => x.UserId == userId);
        }
        public async Task<UserRefreshTokenDto> GetByUserFromRefreshToken(string refreshToken)
        {
            return await _context.UserRefreshTokens.SingleOrDefaultAsync(x => x.Code==refreshToken);
        }

        public async Task AddAsync(UserRefreshTokenDto userRefreshToken)
        {
            await _context.UserRefreshTokens.AddAsync(userRefreshToken);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveByUserIdAsync(string userId)
        {
            var userRefreshToken = await GetByUserIdAsync(userId);
            if (userRefreshToken != null)
            {
                _context.UserRefreshTokens.Remove(userRefreshToken);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(UserRefreshTokenDto userRefreshToken)
        {
            _context.UserRefreshTokens.Update(userRefreshToken);
            await _context.SaveChangesAsync();
        }
    }

}
