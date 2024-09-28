using GTSProject.Services.File.Entities;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;

namespace GTSProject.Services.File.DbSettings.Concrete
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;
        public MongoDbContext(IConfiguration configuration)
        {

            // Bağlantı dizesini al
            var connectionString = configuration.GetConnectionString("MongoDb");

            // Mongo URL nesnesi oluştur
            var mongoUrl = new MongoUrl(connectionString);

            // MongoClient oluştur
            var client = new MongoClient(mongoUrl);

            // Veritabanı adını bağlantı dizesinden al
            _database = client.GetDatabase(mongoUrl.DatabaseName);
        }

        // FileEntity koleksiyonuna erişim
        public IMongoCollection<UploadFile> UploadFiles => _database.GetCollection<UploadFile>("UploadFiles");
    }
}
