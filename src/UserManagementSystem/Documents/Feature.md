# Kullanıcı Yönetim Sistemi

*Kullanıcı Bilgileri: Kullanıcı profili yönetimi ve güncelleme.

*Kullanıcı Rolleri: Roller ve kullanıcıların bu rollere atanması.

*Oturum Yönetimi: Aktif oturumları görüntüleme ve sonlandırma yeteneği.

*Token ile Giriş: JWT ile kimlik doğrulama ve yetkilendirme.

*Rol Yetkileri: Rol bazlı erişim kontrolü.

*Mail ile Onaylı Hesap Kayıt: E-posta doğrulama ve hesap aktivasyonu.

*Şifre Sıfırlama: Kullanıcıların e-posta yoluyla şifrelerini sıfırlama imkanı.

*Kullanıcı Etkinlik Günlüğü: Kullanıcıların giriş ve diğer önemli eylemlerinin kaydını tutma.

*Detaylı Hata ve Loglama: Sistem hatalarını ve önemli olayları kaydetme ve izleme.

























## Kullanılan Kütüphaneler 



### Microsoft.EntityFrameworkCore (8.0.6) MIT LICENSE
Entity Framework Core, veritabanı işlemlerini kolaylaştıran ve yöneten bir ORM (Object-Relational Mapping) kütüphanesidir.

### Microsoft.EntityFrameworkCore.Design (8.0.6) MIT LICENSE
Entity Framework Core için tasarım zamanı araçlarını sağlayan bir kütüphanedir, migration yönetimi gibi görevleri kolaylaştırır.

### Microsoft.EntityFrameworkCore.SqlServer (8.0.6) MIT LICENSE
Entity Framework Core için SQL Server veritabanı ile etkileşim sağlayan sürücü kütüphanesidir.

## Microsoft.EntityFrameworkCore.Tools (8.0.6) MIT LICENSE:
Entity Framework Core kullanarak veritabanı işlemleri ve yönetimi için komut satırı araçları sağlar. (Migration işlemlerinde kolaylık sağlar.)

### Swashbuckle.AspNetCore (6.6.2) MIT LICENSE
ASP.NET Core uygulamaları için Swagger tabanlı API dokümantasyonu ve keşif aracıdır, interaktif API belgeleri oluşturur ve Swagger UI sağlar.

### FluentValidation.AspNetCore (11.3.0) Apache-2.0 LICENSE:
Input validasyonu için kullanılır. HTTPS isteklerinin doğrulanması ve validasyonu için FluentValidation kullanımı yaygındır.

### Microsoft.AspNetCore.Authentication.JwtBearer  (8.0.6) MIT LICENSE:
ASP.NET Core uygulamalarında JWT ile kimlik doğrulama sağlar, Bu tokenler değiştirilemez bilgileri barındırabilir.

### Microsoft.AspNetCore.Identity.EntityFrameworkCore  (8.0.6) MIT LICENSE:
ASP.NET Core uygulamalarında kimlik yönetimi için Entity Framework Core desteği sağlar.











## Kullanılacak Desenler (Patterns):
### Repository Pattern:
Veritabanı işlemlerini soyutlar ve bu işlemleri yöneten repository sınıfları kullanılır. Bu sayede veritabanı işlemleri kolayca değiştirilebilir veya test edilebilir hale gelir.

### Dependency Injection (DI):
Servislerin ve repository sınıflarının DI ile enjekte edilmesi, bağımlılıkları yönetmek için önemlidir. ASP.NET Core'da bu standart bir özelliktir ve Microsoft.Extensions.DependencyInjection kütüphanesi ile kullanılır. IoC Konteyneri Kullanımı (Dependency Injection Örneği) direk kütüphaneyi dahil eder bu sebeple ayrı bir kütüphane eklenmesine gerek yoktur.

### DTO (Data Transfer Object) Pattern:
API ile veri alışverişi yaparken, entity modelleri yerine DTO'lar kullanılması önerilir. DTO'lar, sadece ilgili verileri taşır ve gereksiz bilgi sızıntısını önler.

### Service Layer Pattern:
İş mantığını ve iş süreçlerini yönetmek için servis sınıfları kullanılabilir. Controller sınıfları sadece HTTP isteklerini yönetirken, servis sınıfları iş mantığını uygular.

### Unit Of Work Pattern
Unit of Work deseni; birden çok satır ekleme işlemi yaparken, aradaki modellerden bir tanesi hatalıysa tüm işlemi iptal etmemek için modelleri ayrı ve yönetilebilir kılmak amacıyla kullanılır. Bu deseni bu amaçla dahil ettik.










## Klasör Yapısı

- **Properties**: 
- **Controllers**: API endpoint'lerini tanımlayan ve HTTPS isteklerini yöneten sınıfları içerir.
- **Documents**: Projeye yönelik dökümanlar bulunur.
- **Exceptions**: Özel durumlar ve istisnalar için sınıflar.
- **Extensions**: Genişletme metotları, örneğin IServiceCollection genişletme metotları burada tanımlanabilir.
- **Migrations**: Veritabanı migrations'larını içeren klasör.
- **Models**:
  - **DTOs**: API ile iletişimde kullanılan veri transfer nesneleri.
  - **Entities**: Veritabanı tablolarının veya entity sınıflarının modelleri.
  - **DbContext**: Veritabanı bağlantısını ve ilişkili ayarları yöneten DbContext sınıfı.
- **Repositories**: Veritabanı işlemlerini yapan sınıflar.
- **Services**: İş mantığı kurallarını uygulayan ve repository aracılığıyla veritabanı işlemlerini yöneten servisler.
- **AppSettings.json**: Uygulama ayarları burada saklanır.
- **Program.cs**: Uygulamanın başlangıç noktası ve DI (Dependency Injection) ayarları burada yapılır.
- **README.md**:

```

│   ├── UserManagementSystem
│   │   ├── Properties
│   │   ├── Controllers
│   │   ├── Documents
│   │   ├── Exceptions
│   │   ├── Extensions
│   │   ├── Migrations
│   │   ├── Models
│   │   ├── Repositories
│   │   ├── Services
│   │   │   └── Interfaces
│   │   │   ├── Implementations
│   │   ├   └── ...
│   │   ├── Validators
│   │   ├── appsettings.json
│   │   ├── Program.cs

```


























## Kullanılan Teknolojiler

Bu projede .NET Core kullanılmış olup, Entity Framework Core ile veritabanı işlemleri yönetilmektedir. Proje, microservices mimarisi doğrultusunda modüler bir yapıya sahiptir.

## Başlangıç

Projeyi yerel makinanızda çalıştırmak için aşağıdaki adımları izleyebilirsiniz:

1. **Gereksinimler**
   - .NET Core SDK (sürüm x.x veya üzeri)
   - Visual Studio Code veya Visual Studio IDE

2. **Kurulum**
   - Proje dizinine geçin: `cd /path/to/your/project`
   - Uygulama bağımlılıklarını yüklemek için terminal veya komut istemcisinde aşağıdaki komutu çalıştırın:
     ```
     dotnet restore
     ```

3. **eğer bu kodu yapıştırıp çalıştırırsanız migration yaparken(update-database)**
   
     ```
     dotnet tool install --global dotnet-ef
     ```

4. **Çalıştırma**
   - Uygulamayı başlatmak için terminal veya komut istemcisinde aşağıdaki komutu çalıştırın:
     ```
     dotnet run
     ```



## Daha Fazla Bilgi

Daha fazla bilgi için lütfen [Wiki](/wiki) sayfamızı ziyaret edin veya [Dokümantasyon](/docs) bölümündeki belgelere göz atın.

---

© 2024 GTS Corporation.
