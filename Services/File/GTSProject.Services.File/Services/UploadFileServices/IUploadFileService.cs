using GTSProject.Services.File.Dtos.RequestDtos.UploadFileRequestDtos;
using GTSProject.Services.File.Dtos.UploadFileDtos;
using GTSProject.Services.File.Entities;
using GTSProject.Services.File.PublicFolder.ResultTools;

namespace GTSProject.Services.File.Services.UploadFileServices
{
    public interface IUploadFileService
    {
        Task<IDataResult<UploadFile>> GetFileByIdAsync(Guid id, string storageProvider);
        Task<IEnumerable<UploadFile>> GetAllFilesAsync(string storageProvider);
        Task AddFileAsync(CreateUploadFileRequestDto createUploadFileRequestDto);
        Task UpdateFileAsync(UpdateUploadFileDto updateUploadFileDto);
        Task DeleteFileAsync(Guid id, string storageProvider);
        Task AddMultipleFilesAsync(CreateMultipleUploadFileRequestDto createMultipleUploadFileRequestDto); // Multiple upload fonksiyonu
    }
}
