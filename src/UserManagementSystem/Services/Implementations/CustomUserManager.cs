using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using UserManagementSystem.Models.Entities;
using UserManagementSystem.Validators;

namespace UserManagementSystem.Services.Implementations
{
    public class CustomUserManager : UserManager<FupiUser>
    {
        public CustomUserManager(IUserStore<FupiUser> store, IOptions<IdentityOptions> optionsAccessor, IPasswordHasher<FupiUser> passwordHasher, IEnumerable<IUserValidator<FupiUser>> userValidators, IEnumerable<IPasswordValidator<FupiUser>> passwordValidators, ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, IServiceProvider services, ILogger<UserManager<FupiUser>> logger)
            : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
            // Özel UserValidator ekleyin
            this.UserValidators.Add(new CustomUserValidator());
        }
        public async Task<FupiUser> FindByPhoneNumberAsync(string phoneNumber)
        {
            return await Users.FirstOrDefaultAsync(u => u.PhoneNumber == phoneNumber);
        }
        // Özel metodlarınızı ve özelliklerinizi buraya ekleyebilirsiniz.
    }
}
