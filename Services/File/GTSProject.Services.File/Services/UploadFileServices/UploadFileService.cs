using AutoMapper;
using GTSProject.Services.File.Dtos.RequestDtos.UploadFileRequestDtos;
using GTSProject.Services.File.Dtos.UploadFileDtos;
using GTSProject.Services.File.Entities;
using GTSProject.Services.File.PublicFolder.ResultTools;
using GTSProject.Services.File.Repositories.RepositoryFactories;

namespace GTSProject.Services.File.Services.UploadFileServices
{
    public class UploadFileService : IUploadFileService
    {
        //private readonly IUploadFileRepository _sqlRepository;
        //private readonly IUploadFileRepository _mongoRepository;
        private readonly IRepositoryFactory _repositoryFactory;
        private readonly IMapper _mapper;

        //private readonly AzureBlobStorageService _blobService;
        public UploadFileService(IMapper mapper, IRepositoryFactory repositoryFactory)
        {

            _mapper = mapper;
            _repositoryFactory = repositoryFactory;
        }


        public async Task AddFileAsync(CreateUploadFileRequestDto createUploadFileRequestDto)
        {
            var repository = _repositoryFactory.Create(createUploadFileRequestDto.StorageProvider);

            try
            {
                // Benzersiz bir GUID oluşturun
                var uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(createUploadFileRequestDto.FormFile.FileName);

                // wwwroot/Uploads klasörünün tam yolunu alın
                //var uploadsFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Uploads/MssqlUpload");
                var uploadsFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Uploads", createUploadFileRequestDto.StorageProvider == "mssql" ? "MssqlUpload" : "MongoUpload");
                // Eğer Uploads klasörü yoksa oluşturun
                if (!Directory.Exists(uploadsFolderPath))
                {
                    Directory.CreateDirectory(uploadsFolderPath);
                }

                // Dosyanın yükleneceği hedef yolu belirleyin
                var filePath = Path.Combine(uploadsFolderPath, uniqueFileName);

                // Dosyayı belirtilen hedefe kaydedin
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await createUploadFileRequestDto.FormFile.CopyToAsync(stream);
                }
                CreateUploadFileDto createUploadFileDto = new CreateUploadFileDto();
                // UploadedFile nesnesini DTO'dan oluşturun
                var uploadedFile = _mapper.Map<UploadFile>(createUploadFileDto);

                // Benzersiz dosya adını ve dosya yolunu UploadedFile nesnesine ekleyin
                uploadedFile.FileName = uniqueFileName;
                uploadedFile.FilePath = filePath;
                uploadedFile.StorageProvider = createUploadFileRequestDto.StorageProvider;
                uploadedFile.CreatedAt = DateTime.Now;
                uploadedFile.CreatedBy = "mssql";
                uploadedFile.Size = createUploadFileRequestDto.FormFile.Length;
                uploadedFile.ContentType = createUploadFileRequestDto.FormFile.ContentType;

                // Dosya bilgilerini veritabanına ekleyin
                await repository.AddFileAsync(uploadedFile);
                //await _uploadedFileCollection.InsertOneAsync(uploadedFile);
            }
            catch (Exception ex)
            {
                // Hata durumunda loglama yapabilir veya özel işlemler gerçekleştirebilirsiniz
                Console.WriteLine($"Dosya yüklenirken bir hata oluştu: {ex.Message}");
                // Gerekirse özel bir hata fırlatabilirsiniz
                throw;
            }




        }

        public async Task AddMultipleFilesAsync(CreateMultipleUploadFileRequestDto createMultipleUploadFileRequestDto)
        {
            foreach (var file in createMultipleUploadFileRequestDto.FormFiles)
            {
                //var addingFile = _mapper.Map<CreateUploadFileRequestDto>(file);
                //addingFile.StorageProvider = createMultipleUploadFileRequestDto.StorageProvider;
                //await AddFileAsync(addingFile);
                var addingFile = _mapper.Map<CreateUploadFileRequestDto>(file);
                if (addingFile == null || addingFile.FormFile == null)
                {
                    Console.WriteLine("Mapping failed for file: " + file.FileName);
                }
                addingFile.StorageProvider = createMultipleUploadFileRequestDto.StorageProvider;
                await AddFileAsync(addingFile);
            }
        }

        public async Task DeleteFileAsync(Guid id, string storageProvider)
        {
            var repository = _repositoryFactory.Create(storageProvider);
            await repository.DeleteFileAsync(id);

        }

        public async Task<IEnumerable<UploadFile>> GetAllFilesAsync(string storageProvider)
        {
            var repository = _repositoryFactory.Create(storageProvider);
            return await repository.GetAllFilesAsync();


        }


        public async Task<IDataResult<UploadFile>> GetFileByIdAsync(Guid id, string storageProvider)
        {
            var repository = _repositoryFactory.Create(storageProvider);
            UploadFile result = await repository.GetFileByIdAsync(id);
            if(result == null)
            {
                return new ErrorDataResult<UploadFile>(result, "Liste Boş","400");
            }
            return new SuccessDataResult<UploadFile>(result, "Başarılı", "200");

        }

        //Update'e tekrar bak
        public async Task UpdateFileAsync(UploadFile file)
        {
            var repository = _repositoryFactory.Create(file.StorageProvider);

            await repository.UpdateFileAsync(file);

        }

        public Task UpdateFileAsync(UpdateUploadFileDto updateUploadFileDto)
        {
            throw new NotImplementedException();
        }

       

        //azure eklenince
        //public async Task<UploadFile> UploadFileAsync(IFormFile file, string storageProvider)
        //{
        //    var fileEntity = new UploadFile
        //    {
        //        Id = Guid.NewGuid(),
        //        FileName = file.FileName,
        //        ContentType = file.ContentType,
        //        Size = file.Length,
        //        StorageProvider = storageProvider,
        //        CreatedAt = DateTime.UtcNow,
        //        CreatedBy = "User" // Burayı gerektiği gibi ayarlayın
        //    };

        //    switch (storageProvider.ToLower())
        //    {
        //        case "mssql":
        //            await _sqlRepository.AddFileAsync(fileEntity);
        //            break;
        //        case "mongodb":
        //            await _mongoRepository.AddFileAsync(fileEntity);
        //            break;
        //        //case "azureblob":
        //        //    fileEntity.StoragePath = await _blobService.UploadFileAsync(file);
        //        //    await _sqlRepository.AddFileAsync(fileEntity); // MSSQL'e metadata kaydediyoruz
        //        //    break;
        //        default:
        //            throw new ArgumentException("Geçersiz storage provider");
        //    }

        //    return fileEntity;
        //}




        //public async Task AddFileAsync(UploadFile file)
        //{
        //    // Dosyayı hem SQL'e hem de MongoDB'ye ekleyin
        //    await _sqlRepository.AddFileAsync(file);
        //    await _mongoRepository.AddFileAsync(file);

        //    // Ayrıca Azure Blob Storage'a da yükleyebilirsiniz
        //    //await _blobService.UploadFileAsync(file);
        //}
        //public async Task<UploadFile> GetFileByIdAsync(Guid id)
        //{
        //    // İlk önce SQL'den almayı deneyin, MongoDB'ye düşebilir
        //    var file = await _sqlRepository.GetFileByIdAsync(id);
        //    if (file == null)
        //    {
        //        file = await _mongoRepository.GetFileByIdAsync(id);
        //    }
        //    return file;
        //}
        //public async Task DeleteFileAsync(Guid id)
        //{
        //    await _sqlRepository.DeleteFileAsync(id);
        //    await _mongoRepository.DeleteFileAsync(id);

        //    // Blob'dan da silmeyi unutmayın
        //    //await _blobService.DeleteFileAsync(id);
        //}

        //public async Task<IEnumerable<UploadFile>> GetAllFilesAsync()
        //{
        //    // SQL ve MongoDB'den dosyaları birleştirin
        //    var sqlFiles = await _sqlRepository.GetAllFilesAsync();
        //    var mongoFiles = await _mongoRepository.GetAllFilesAsync();
        //    return sqlFiles.Concat(mongoFiles);
        //}
        //public async Task UpdateFileAsync(UploadFile file)
        //{
        //    await _sqlRepository.UpdateFileAsync(file);
        //    await _mongoRepository.UpdateFileAsync(file);
        //}
    }
}
