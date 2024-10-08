using GTSProject.Services.File.Dtos.RequestDtos.UploadFileRequestDtos;
using GTSProject.Services.File.Dtos.UploadFileDtos;
using GTSProject.Services.File.Entities;
using GTSProject.Services.File.PublicFolder.ResultTools;

namespace GTSProject.Services.File.Services.UploadFileServices
{
    public interface IUploadFileService
    {
        Task<IDataResult<UploadFile>> GetFileByIdAsync(ResultGetByIdUploadFileRequestDto resultGetByIdUploadFileRequestDto);
        Task<IDataResult<IEnumerable<UploadFile>>> GetAllFilesMssqlAsync();
        Task<IDataResult<IEnumerable<UploadFile>>> GetAllFilesMongoAsync();
        Task<PublicFolder.ResultTools.IResult> AddFileAsync(CreateUploadFileRequestDto createUploadFileRequestDto);
        Task<PublicFolder.ResultTools.IResult> DeleteFileAsync(DeleteUploadFileRequestDto deleteUploadFileRequestDto);
        Task<PublicFolder.ResultTools.IResult> AddMultipleFilesAsync(CreateMultipleUploadFileRequestDto createMultipleUploadFileRequestDto); // Multiple upload fonksiyonu
        //Task UpdateFileAsync(UpdateUploadFileDto updateUploadFileDto); //sonra bakılacak versiyonlama yapılabilir bir düşün
    }

}
