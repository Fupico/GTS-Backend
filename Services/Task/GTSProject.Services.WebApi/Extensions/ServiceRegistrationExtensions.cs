using GTSProject.Services.Core.Business.Abstract;
using GTSProject.Services.Core.UnitOfWork;
using GTSProject.Services.DataAccess.Concrete;
using GTSProject.Services.WebApi.Mapping;
using System.Reflection;

public static class ServiceRegistrationExtensions
{
    public static void RegisterServices(this IServiceCollection services)
    {
        // Assembly'i alıyoruz
        var assembly = Assembly.GetExecutingAssembly();

        // IService<> generic türünü tanımlıyoruz
        var serviceType = typeof(IService<,,,,>);

        // Assembly'deki tüm sınıfları buluyoruz
        var types = assembly.GetTypes()
            .Where(t => t.IsClass && !t.IsAbstract)
            .ToList();

        // Her bir implementasyon tipi için döngü başlatıyoruz
        foreach (var implementationType in types)
        {
            // IService<> arayüzlerini buluyoruz
            var interfaces = implementationType.GetInterfaces()
                .Where(i => i.IsGenericType && i.GetGenericTypeDefinition() == serviceType)
                .ToList();

            // Her bir IService<>'yi AddScoped ile kaydediyoruz
            foreach (var interfaceType in interfaces)
            {
                services.AddScoped(interfaceType, implementationType);
            }

            // Spesifik servis arayüzlerini buluyoruz (I...Service)
            var serviceInterfaces = implementationType.GetInterfaces()
                .Where(i => i.Name.StartsWith("I") && i.Name.EndsWith("Service"))
                .ToList();

            // Her bir servis arayüzünü AddTransient ile kaydediyoruz
            foreach (var serviceInterface in serviceInterfaces)
            {
                services.AddTransient(serviceInterface, implementationType);
            }

            // Data Access (DAL) arayüzlerini buluyoruz (I...Dal)
            var dalInterfaces = implementationType.GetInterfaces()
                .Where(i => i.Name.StartsWith("I") && i.Name.EndsWith("Dal"))
                .ToList();

            // Her bir DAL arayüzünü AddTransient ile kaydediyoruz
            foreach (var dalInterface in dalInterfaces)
            {
                services.AddTransient(dalInterface, implementationType);
            }
        }

        // Unit of Work ve AutoMapper kaydı
        services.AddScoped<IUnitOfWork<TaskServiceContext>, UnitOfWork<TaskServiceContext>>();
        services.AddAutoMapper(typeof(AutoMapperProfile));
    }
}