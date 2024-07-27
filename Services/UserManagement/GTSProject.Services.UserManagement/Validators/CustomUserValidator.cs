using Microsoft.AspNetCore.Identity;
using UserManagementSystem.Models.Entities;

namespace UserManagementSystem.Validators
{
    public class CustomUserValidator : IUserValidator<FupiUser>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<FupiUser> manager, FupiUser user)
        {
            List<IdentityError> errors = new List<IdentityError>();

            // E-posta kontrolü
            if (!IsValidEmail(user.Email))
            {
                errors.Add(new IdentityError
                {
                    Code = "InvalidEmail",
                    Description = "Invalid email address."
                });
            }

            // Kullanıcı adı kontrolü
            if (!IsValidUsername(user.UserName))
            {
                errors.Add(new IdentityError
                {
                    Code = "InvalidUsername",
                    Description = "Username is invalid. It must be at least 5 characters."
                });
            }

            // Telefon numarası kontrolü
            if (!IsValidPhoneNumber(user.PhoneNumber))
            {
                errors.Add(new IdentityError
                {
                    Code = "InvalidPhoneNumber",
                    Description = "Invalid phone number."
                });
            }

            return Task.FromResult(errors.Count == 0 ? IdentityResult.Success : IdentityResult.Failed(errors.ToArray()));
        }

        private bool IsValidEmail(string email)
        {
            // E-posta kontrolü burada yapılır, örneğin bir regex ile
            // Örnek: return Regex.IsMatch(email, "geçerli bir e-posta regex'i");
            return true; // Geçici olarak true döndürdük
        }

        private bool IsValidUsername(string username)
        {
            if (username.ToLower() == "atatürk" || username.ToUpper() == "ATATURK" || username.ToUpper() == "ATATÜRK")
            {
                return false;
            }
            if (username.Length < 5)
            {
                // Kullanıcı adı minimum 5 karakter olmalı
                return false;
            }
            // Kullanıcı adı kontrolü burada yapılır, örneğin bir regex ile
            // Örnek: return Regex.IsMatch(username, "geçerli bir kullanıcı adı regex'i");
            return true; // Geçici olarak true döndürdük
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Telefon numarası kontrolü burada yapılır, örneğin bir regex ile
            // Örnek: return Regex.IsMatch(phoneNumber, "geçerli bir telefon numarası regex'i");
            return true; // Geçici olarak true döndürdük
        }
    }
}
