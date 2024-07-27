using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UserManagementSystem.Models.Dtos.BaseDtos;
using UserManagementSystem.Models.Dtos.UserDtos;
using UserManagementSystem.Models.Entities;
using UserManagementSystem.Services.Interfaces;

namespace UserManagementSystem.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly UserManager<FupiUser> _userManager;

        public UserService(UserManager<FupiUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<ResponseDto<List<GetBirthdaysThisWeekDto>>> GetBirthdaysThisWeek()
        {
            var today = DateTime.Today;
            var oneWeekLater = today.AddDays(7);

            var birthdaysThisWeekUser = await _userManager.Users.Where(u =>
                // Kullanıcının doğum günü bu yıl içinde 7 gün içinde mi?
                ((u.DateOfBirth.Value.Month == today.Month && u.DateOfBirth.Value.Day >= today.Day) ||
                (u.DateOfBirth.Value.Month == oneWeekLater.Month && u.DateOfBirth.Value.Day <= oneWeekLater.Day))
                &&
                // Genel kontrol: Kullanıcının doğum günü bu ayın kalan günlerinde mi veya gelecek ayın ilk günlerinde mi?
                (u.DateOfBirth.Value.Month == today.Month || u.DateOfBirth.Value.Month == oneWeekLater.Month)
            )
                .Select(x => new GetBirthdaysThisWeekDto
            {
                DayOfBirth = x.DateOfBirth ?? default,
                FullName = x.Name + " " + x.Surname
            }).ToListAsync();

            return new ResponseDto<List<GetBirthdaysThisWeekDto>>
            {
                Data = birthdaysThisWeekUser,
                status = 200,
                IsSuccessful = true,
            };
        }
    }
}
