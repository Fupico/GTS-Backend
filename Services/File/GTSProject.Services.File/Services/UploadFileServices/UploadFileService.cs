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


        public async Task<PublicFolder.ResultTools.IResult> AddFileAsync(CreateUploadFileRequestDto createUploadFileRequestDto)
        {
            
            try
            {
                var repository = _repositoryFactory.Create(createUploadFileRequestDto.StorageProvider);
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
                uploadedFile.CreatedBy = "USERID";
                uploadedFile.Size = createUploadFileRequestDto.FormFile.Length;
                uploadedFile.ContentType = createUploadFileRequestDto.FormFile.ContentType;

                // Dosya bilgilerini veritabanına ekleyin
                await repository.AddFileAsync(uploadedFile);
                return new SuccessResult("Dosya başarıyla eklendi.", "200");

            }
            catch (Exception ex)
            {
                // Hata durumunda loglama yapabilir veya özel işlemler gerçekleştirebilirsiniz
                // Gerekirse özel bir hata fırlatabilirsiniz
                
                return new ErrorResult($"Dosya yüklenirken bir hata oluştu: {ex.Message}", "400");
            }




        }

        public async Task<PublicFolder.ResultTools.IResult> AddMultipleFilesAsync(CreateMultipleUploadFileRequestDto createMultipleUploadFileRequestDto)
        {
            try
            {
                foreach (var file in createMultipleUploadFileRequestDto.FormFiles)
                {
                    //var addingFile = _mapper.Map<CreateUploadFileRequestDto>(file);
                    //addingFile.StorageProvider = createMultipleUploadFileRequestDto.StorageProvider;
                    //await AddFileAsync(addingFile);
                    var addingFile = _mapper.Map<CreateUploadFileRequestDto>(file);
                    if (addingFile == null || addingFile.FormFile == null)
                    {
                        throw new Exception("Mapping failed for file: " + file.FileName);
                        
                    }
                    addingFile.StorageProvider = createMultipleUploadFileRequestDto.StorageProvider;
                    await AddFileAsync(addingFile);

                }
                return new SuccessResult("Dosyalar başarıyla eklendi.", "200");

            }
            catch (Exception ex)
            {

                return new ErrorResult($"Dosyalar yüklenirken bir hata oluştu: {ex.Message}", "400");
            }
            
        }

        public async Task<PublicFolder.ResultTools.IResult> DeleteFileAsync(DeleteUploadFileRequestDto deleteUploadFileRequestDto)
        {
            try
            {
                var repository = _repositoryFactory.Create(deleteUploadFileRequestDto.StorageProvider);
                await repository.DeleteFileAsync(deleteUploadFileRequestDto.Id);
                return new SuccessResult("Dosyalar başarıyla silindi.", "200");

            }
            catch (Exception ex)
            {

                return new ErrorResult($"Dosya silinirken bir hata oluştu: {ex.Message}", "400");
            }
            
        }


        public async Task<IDataResult<IEnumerable<UploadFile>>> GetAllFilesMongoAsync()
        {
            ResultGetAllUploadFileMongoRequestDto resultGetAllUploadFileMongoRequestDto = new ResultGetAllUploadFileMongoRequestDto
            {
                StorageProvider = "mongodb"
            };
            try
            {
                var repository = _repositoryFactory.Create(resultGetAllUploadFileMongoRequestDto.StorageProvider);
                IEnumerable<UploadFile> result = await repository.GetAllFilesAsync();
                
                return new SuccessDataResult<IEnumerable<UploadFile>>(result, "Başarılı", "200");
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<IEnumerable<UploadFile>>(null, $"Listenme isteği başarısız oldu: {ex.Message}", "400");
            }

        }

        public async Task<IDataResult<IEnumerable<UploadFile>>> GetAllFilesMssqlAsync()
        {

            ResultGetAllUploadFileMssqlRequestDto resultGetAllUploadFileMssqlRequestDto = new ResultGetAllUploadFileMssqlRequestDto
            {
                StorageProvider = "mssql"
            };
            try
            {
                var repository = _repositoryFactory.Create(resultGetAllUploadFileMssqlRequestDto.StorageProvider);
                IEnumerable<UploadFile> result = await repository.GetAllFilesAsync();

                return new SuccessDataResult<IEnumerable<UploadFile>>(result, "Başarılı", "200");
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<IEnumerable<UploadFile>>(null, $"Listenme isteği başarısız oldu: {ex.Message}", "400");
            }
        }

        public async Task<IDataResult<UploadFile>> GetFileByIdAsync(ResultGetByIdUploadFileRequestDto resultGetByIdUploadFileRequestDto)
        {
            try
            {
                var repository = _repositoryFactory.Create(resultGetByIdUploadFileRequestDto.StorageProvider);
                UploadFile result = await repository.GetFileByIdAsync(resultGetByIdUploadFileRequestDto.Id);
                return new SuccessDataResult<UploadFile>(result, "Başarılı", "200");
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<UploadFile>(null, $"Görüntüleme isteği başarısız oldu: {ex.Message}", "400");
            }
        }

        //Update'e tekrar bak
        //public async Task UpdateFileAsync(UploadFile file)
        //{
        //    var repository = _repositoryFactory.Create(file.StorageProvider);

        //    await repository.UpdateFileAsync(file);

        //}

        //public async Task UpdateFileAsync(UpdateUploadFileDto updateUploadFileDto)
        //{
        //    throw new NotImplementedException();
        //}



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
