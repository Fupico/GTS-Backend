using GTSProject.Services.UserManagement.Models.Dtos.TrainingDtos;
using GTSProject.Services.UserManagement.Models.Dtos.UserDtos;
using UserManagementSystem.Models.Dtos.BaseDtos;

namespace GTSProject.Services.UserManagement.Services.Interfaces
{
    public interface ITrainingService
    {
        Task<ResponseDto<GetTrainingDto>> GetTrainingById(string id);
        Task<ResponseDto<List<GetTrainingDto>>> GetTraining();
        Task<ResponseDto<NoDataDto>> InsertTraining(InsertTrainingDto insertTrainingDto);
        Task<ResponseDto<NoDataDto>> UpdateTraining(UpdateTrainingDto updateTrainingDto);
        Task<ResponseDto<NoDataDto>> DeleteTraining(DeleteTrainingDto deleteTrainingDto);
    }
}
