using GTSProject.Services.File.DbSettings.Concrete;
using GTSProject.Services.File.Entities;
using MongoDB.Driver;

namespace GTSProject.Services.File.Repositories.UploadFileRepositories
{
    public class MongoUploadFileRepository : IUploadFileRepository
    {
        private readonly IMongoCollection<UploadFile> _files;

        public MongoUploadFileRepository(MongoDbContext context)
        {
            _files = context.UploadFiles;
        }
        public async Task AddFileAsync(UploadFile file)
        {
            await _files.InsertOneAsync(file);
        }

        public async Task DeleteFileAsync(Guid id)
        {
            var filter = Builders<UploadFile>.Filter.Eq(f => f.Id, id);
            await _files.DeleteOneAsync(filter);
        }

        public async Task<IEnumerable<UploadFile>> GetAllFilesAsync()
        {
            return await _files.Find(_ => true).ToListAsync();
        }

        public async Task<UploadFile> GetFileByIdAsync(Guid id)
        {
            var filter = Builders<UploadFile>.Filter.Eq(f => f.Id, id);
            return await _files.Find(filter).FirstOrDefaultAsync();
        }

        public async Task UpdateFileAsync(UploadFile file)
        {
            var filter = Builders<UploadFile>.Filter.Eq(f => f.Id, file.Id);
            await _files.ReplaceOneAsync(filter, file);
        }
    }
}
