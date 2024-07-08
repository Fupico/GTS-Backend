using Microsoft.AspNetCore.Identity;
using UserManagementSystem.Models.Dtos.BaseDtos;
using UserManagementSystem.Models.Entities;

namespace UserManagementSystem.Services.Interfaces
{
    public interface ITokenService
    {
        TokenDto CreateToken(FupiUser IdentityUser);

        ClientTokenDto CreateTokenByClient(ClientDto client);
    }
}
