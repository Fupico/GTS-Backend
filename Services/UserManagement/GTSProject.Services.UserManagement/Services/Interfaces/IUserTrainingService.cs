using GTSProject.Services.UserManagement.Models.Dtos.UserTrainingDtos;
using UserManagementSystem.Models.Dtos.BaseDtos;

namespace GTSProject.Services.UserManagement.Services.Interfaces
{
    public interface IUserTrainingService
    {
        Task<ResponseDto<NoDataDto>> AddUserTraining(AddUserTrainingDto addUserTrainingDto);
        Task<ResponseDto<List<GetUserTrainingDto>>> GetUserAttendedTrainings();
        Task<ResponseDto<List<GetUserTrainingDto>>> GetUserNotAttendedTrainings();
        Task<ResponseDto<List<GetUserTrainingDto>>> GetUserRecommendedTrainings();
        Task<ResponseDto<GetUserTrainingDto>> GetRandomNotAttendedTraining();
        Task<ResponseDto<NoDataDto>> UpdateUserTraining(UpdateUserTrainingDto updateUserTrainingDto);
    }
}
