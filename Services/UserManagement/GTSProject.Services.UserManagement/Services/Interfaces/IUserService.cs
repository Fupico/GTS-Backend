using UserManagementSystem.Models.Dtos.BaseDtos;
using UserManagementSystem.Models.Dtos.UserDtos;

namespace UserManagementSystem.Services.Interfaces
{
    public interface IUserService
    {
        Task<ResponseDto<List<GetBirthdaysThisWeekDto>>> GetBirthdaysThisWeek( );
    }
}
