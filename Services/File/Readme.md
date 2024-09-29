## File Service Dizin Yapısı 

### GTSProject.Services.File  
### GTSProject.Services.File   
├── **Controllers**  
│   └── UploadFilesController.cs  
├── **DbSettings**  
│   ├── **Context**  
│   │   ├── MongoDbContext.cs  
│   │   └── MssqlDbContext.cs  
├── **Dtos**  
│   ├── **RequestDtos**  
│   │   ├── **UploadFileRequestDtos**  
│   │   │   ├── CreateMultipleUploadFileRequestDto.cs  
│   │   │   ├── CreateUploadFileRequestDto.cs  
│   │   │   ├── DeleteUploadFileRequestDto.cs  
│   │   │   ├── ResultGetAllUploadFileMongoRequestDto.cs  
│   │   │   ├── ResultGetAllUploadFileMssqlRequestDto.cs  
│   │   │   └── ResultGetByIdUploadFileRequestDto.cs  
│   │   ├── **UploadFileDtos**  
│   │   │   ├── CreateUploadFileDto.cs  
│   │   │   ├── UpdateUploadFileDto.cs  
│   │   │   ├── ResultUploadFileDto.cs  
│   │   │   └── GetByIdUploadFileDto.cs  
├── **Entities**  
│   └── UploadFile.cs  
├── **Mapping**  
│   └── GeneralMapping.cs  
├── **PublicFolder**  
│   └── **ResultTools**  
│   │   ├── DataResult.cs  
│   │   ├── ErrorDataResult.cs  
│   │   ├── ErrorResult.cs  
│   │   ├── IDataResult.cs  
│   │   ├── IResult.cs  
│   │   ├── Result.cs  
│   │   ├── SuccessDataResult.cs  
│   │   └── SuccessResult.cs  
├── **Repositories**  
│   ├── **RepositoryFactories**  
│   │   └── RepositoryFactory.cs  
│   ├── **UploadFileRepositories**  
│   │   ├── IUploadFileRepository.cs  
│   │   ├── MongoUploadFileRepository.cs  
│   │   └── MssqlUploadFileRepository.cs  
├── **Services**  
│   └── **UploadFileServices**  
│   │   ├── IUploadFileService.cs  
│   │   └── UploadFileService.cs  
├── **wwwroot**  
│   └── **Uploads**  
│       ├── MongoUpload  
│       └── MssqlUpload  



File Service dosya yönetimi işlevlerini mikroservis mimarisi prensiplerine uygun gerçekleştiren, modüler, esnek ve ölçeklenebilir bir yapı sunar. 
Farklı veri kaynakları (MongoDB ve MSSQL) ile çalışabilme özelliğine sahiptir ve bu yapılar arasında geçiş yapabilecek şekilde tasarlanmıştır.

?? **Dosya Yükleme ve Yönetimi**
??Ekleme, silme, listeleme, güncelleme gibi tüm dosya yönetimi işlemlerini destekler.
??Dosyalar, ilgili meta veriler ile birlikte veritabanında saklanır.

?? **Modüler Servis Katmanı**
??MSSQL tarafında Entity Framework kullanılır ve bu sayede ilişkisel veritabanı işlemleri yapılır.
??MongoDB tarafında ise NoSQL işlemlerini destekleyen bir yapı vardır. MongoDB için ayrı bir MongoDbContext ve repository bulunmaktadır.

?? **Repository Design Pattern**
??Veritabanı işlemlerini soyutlayarak veri erişimini modüler hale getirmek ve iş mantığından ayırmak.
??Projede hem MSSQL hem de MongoDB için farklı repository'ler oluşturulmuştur:

?? **Factory Design Pattern**
??Hangi veri kaynağıyla (MSSQL veya MongoDB) çalışılacağına runtime'da karar verebilmek. Bu sayede uygulama, farklı ortamlara göre yapılandırılabilir.
?? Factory yapısı, istenilen veritabanına göre ilgili repository’yi sağlar.

?? **DTO (Data Transfer Object) Yapısı**
??Dosya transfer modelleri, veriyi dış dünyaya taşımak için kullanılır. Bu sayede veriler izole edilmiş ve iş mantığı katmanında karmaşıklık en aza indirilmiştir.

?? **AutoMapper**
??Veri transfer nesnelerini iş mantığı katmanından ayırarak, model ile DTO arasındaki dönüştürme süreçlerini basitleştirir ve geliştiricinin manuel mapleme işlemlerinden kaynaklanan hataları minimize eder.
