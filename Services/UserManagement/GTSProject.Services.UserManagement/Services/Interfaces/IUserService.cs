using GTSProject.Services.UserManagement.Models.Dtos.UserDtos;
using UserManagementSystem.Models.Dtos.BaseDtos;
using UserManagementSystem.Models.Dtos.UserDtos;

namespace UserManagementSystem.Services.Interfaces
{
    public interface IUserService
    {
        Task<ResponseDto<List<GetBirthdaysThisWeekDto>>> GetBirthdaysThisWeek( );
        Task<ResponseDto<GetUserProfileDto>> GetUserProfile( );

        Task<ResponseDto<NoDataDto>> UpdateUserProfile(UpdateUserProfileDto updateUserProfileDto);
    }

    
}
