using GTSProject.Services.File.Repositories.UploadFileRepositories;

namespace GTSProject.Services.File.Repositories.RepositoryFactories
{
    public class RepositoryFactory : IRepositoryFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public RepositoryFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IUploadFileRepository Create(string storageProvider)
        {
            return storageProvider.ToLower() switch
            {
                "mssql" => _serviceProvider.GetRequiredService<MssqlUploadFileRepository>(),
                "mongodb" => _serviceProvider.GetRequiredService<MongoUploadFileRepository>(),
                _ => throw new ArgumentException("Geçersiz storage provider"),
            };
        }
    }
    public interface IRepositoryFactory
    {
        IUploadFileRepository Create(string storageProvider);

    }
}
