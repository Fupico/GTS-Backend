using GTSProject.Services.File.Entities;

namespace GTSProject.Services.File.Repositories.UploadFileRepositories
{
    public interface IUploadFileRepository
    {
        Task<UploadFile> GetFileByIdAsync(Guid id);
        Task<IEnumerable<UploadFile>> GetAllFilesAsync();
        Task AddFileAsync(UploadFile file);
        Task UpdateFileAsync(UploadFile file);
        Task DeleteFileAsync(Guid id);
    }
}
