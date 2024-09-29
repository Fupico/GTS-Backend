## File Service Dizin Yapýsý 

### GTSProject.Services.File  
??? **Controllers**  
?   ??? UploadFilesController.cs  
??? **DbSettings**  
?   ??? **Context**  
?   ?   ??? MongoDbContext.cs  
?   ?   ??? MssqlDbContext.cs  
??? **Dtos**  
?   ??? **RequestDtos**  
?   ?   ??? **UploadFileRequestDtos**  
?   ?   ?   ??? CreateMultipleUploadFileRequestDto.cs  
?   ?   ?   ??? CreateUploadFileRequestDto.cs  
?   ?   ?   ??? DeleteUploadFileRequestDto.cs  
?   ?   ?   ??? ResultGetAllUploadFileMongoRequestDto.cs  
?   ?   ?   ??? ResultGetAllUploadFileMssqlRequestDto.cs  
?   ?   ?   ??? ResultGetByIdUploadFileRequestDto.cs  
?   ?   ??? **UploadFileDtos**  
?   ?   ?   ??? CreateUploadFileDto.cs  
?   ?   ?   ??? UpdateUploadFileDto.cs  
?   ?   ?   ??? ResultUploadFileDto.cs  
?   ?   ?   ??? GetByIdUploadFileDto.cs  
??? **Entities**  
?   ??? UploadFile.cs  
??? **Mapping**  
?   ??? GeneralMapping.cs  
??? **PublicFolder**  
?   ??? **ResultTools**  
?   ?   ??? DataResult.cs  
?   ?   ??? ErrorDataResult.cs  
?   ?   ??? ErrorResult.cs  
?   ?   ??? IDataResult.cs  
?   ?   ??? IResult.cs  
?   ?   ??? Result.cs  
?   ?   ??? SuccessDataResult.cs  
?   ?   ??? SuccessResult.cs  
??? **Repositories**  
?   ??? **RepositoryFactories**  
?   ?   ??? RepositoryFactory.cs  
?   ??? **UploadFileRepositories**  
?   ?   ??? IUploadFileRepository.cs  
?   ?   ??? MongoUploadFileRepository.cs  
?   ?   ??? MssqlUploadFileRepository.cs  
??? **Services**  
?   ??? **UploadFileServices**  
?   ?   ??? IUploadFileService.cs  
?   ?   ??? UploadFileService.cs  
??? **wwwroot**  
?   ??? **Uploads**  
?       ??? MongoUpload  
?       ??? MssqlUpload  


File Service dosya yönetimi iþlevlerini mikroservis mimarisi prensiplerine uygun gerçekleþtiren, modüler, esnek ve ölçeklenebilir bir yapý sunar. 
Farklý veri kaynaklarý (MongoDB ve MSSQL) ile çalýþabilme özelliðine sahiptir ve bu yapýlar arasýnda geçiþ yapabilecek þekilde tasarlanmýþtýr.

?? **Dosya Yükleme ve Yönetimi**
??Ekleme, silme, listeleme, güncelleme gibi tüm dosya yönetimi iþlemlerini destekler.
??Dosyalar, ilgili meta veriler ile birlikte veritabanýnda saklanýr.

?? **Modüler Servis Katmaný**
??MSSQL tarafýnda Entity Framework kullanýlýr ve bu sayede iliþkisel veritabaný iþlemleri yapýlýr.
??MongoDB tarafýnda ise NoSQL iþlemlerini destekleyen bir yapý vardýr. MongoDB için ayrý bir MongoDbContext ve repository bulunmaktadýr.

?? **Repository Design Pattern**
??Veritabaný iþlemlerini soyutlayarak veri eriþimini modüler hale getirmek ve iþ mantýðýndan ayýrmak.
??Projede hem MSSQL hem de MongoDB için farklý repository'ler oluþturulmuþtur:

?? **Factory Design Pattern**
??Hangi veri kaynaðýyla (MSSQL veya MongoDB) çalýþýlacaðýna runtime'da karar verebilmek. Bu sayede uygulama, farklý ortamlara göre yapýlandýrýlabilir.
?? Factory yapýsý, istenilen veritabanýna göre ilgili repository’yi saðlar.

?? **DTO (Data Transfer Object) Yapýsý**
??Dosya transfer modelleri, veriyi dýþ dünyaya taþýmak için kullanýlýr. Bu sayede veriler izole edilmiþ ve iþ mantýðý katmanýnda karmaþýklýk en aza indirilmiþtir.

?? **AutoMapper**
??Veri transfer nesnelerini iþ mantýðý katmanýndan ayýrarak, model ile DTO arasýndaki dönüþtürme süreçlerini basitleþtirir ve geliþtiricinin manuel mapleme iþlemlerinden kaynaklanan hatalarý minimize eder.