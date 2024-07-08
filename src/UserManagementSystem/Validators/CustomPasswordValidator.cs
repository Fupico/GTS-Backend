using Microsoft.AspNetCore.Identity;
using UserManagementSystem.Models.Entities;

namespace UserManagementSystem.Validators
{
    public class CustomPasswordValidator : IPasswordValidator<FupiUser>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<FupiUser> manager, FupiUser user, string? password)
        {
            var errors = new List<IdentityError>();
            if (password!.ToLower().Contains(user.UserName!.ToLower()))
            {
                errors.Add(new() { Code = "PasswordNoContainUserName", Description = "The password field cannot contain a user name." });
            }
            if (errors.Any())
            {
                return Task.FromResult(IdentityResult.Failed(errors.ToArray()));
            }

            return Task.FromResult(IdentityResult.Success);
        }
    }
}
