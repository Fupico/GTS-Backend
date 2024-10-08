using GTSProject.Services.File.DbSettings.Concrete;
using GTSProject.Services.File.Entities;
using Microsoft.EntityFrameworkCore;

namespace GTSProject.Services.File.Repositories.UploadFileRepositories
{
    public class MssqlUploadFileRepository : IUploadFileRepository
    {
        private readonly MssqlDbContext _context;

        public MssqlUploadFileRepository(MssqlDbContext context)
        {
            _context = context;
        }

        public async Task AddFileAsync(UploadFile file)
        {
            await _context.UploadFiles.AddAsync(file);
            await _context.SaveChangesAsync();
        }


        public async Task DeleteFileAsync(Guid id)
        {
            var file = await _context.UploadFiles.FindAsync(id);
            if (file != null)
            {
                _context.UploadFiles.Remove(file);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<UploadFile>> GetAllFilesAsync()
        {
            return await _context.UploadFiles.ToListAsync();
        }

        public async Task<UploadFile> GetFileByIdAsync(Guid id)
        {
            return await _context.UploadFiles.FindAsync(id);
        }

        public async Task UpdateFileAsync(UploadFile file)
        {
            _context.UploadFiles.Update(file);
            await _context.SaveChangesAsync();
        }
    }
}
