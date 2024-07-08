using Microsoft.AspNetCore.Authentication;

namespace UserManagementSystem.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddScopedServices(this IServiceCollection services)
        {
            //services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            //services.AddScoped(typeof(IServiceGeneric<,>), typeof(ServiceGeneric<,>));
            //services.AddScoped<IAuthenticationService, AuthenticationService>();
            //services.AddScoped<IUserService, UserService>();
            //services.AddScoped<ITokenService, TokenService>();

            //services.AddScoped<IVersionService, VersionService>();


            //services.AddScoped<IEmailService, EmailService>();
            //// Authentication and token services
            //services.AddScoped<IAuthenticationService, AuthenticationService>();
            //services.AddScoped<ITokenService, TokenService>();

            //// Generic repository services
            //services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            //services.AddScoped(typeof(IServiceGeneric<,>), typeof(ServiceGeneric<,>));


            //// Workplace related services
            //services.AddScoped<IWorkplaceService, WorkplaceService>();
            //services.AddScoped<IWorkplaceRepository, WorkplaceRepository>();


            //// Workplace related services
            //services.AddScoped<IMaterialService, MaterialService>();
            //services.AddScoped<IMaterialRepository, MaterialRepository>();

            //// UserLog Service
            //services.AddScoped<IUserLogService, UserLogService>();
            //services.AddScoped<IUserLogRepository, UserLogRepository>();

            //// LogOperationType Service
            //services.AddScoped<ILogOperationTypeService, LogOperationTypeService>();
            //services.AddScoped<ILogOperationTypeRepository, LogOperationTypeRepository>();

            //// Employee Service
            //services.AddScoped<IEmployeeService, EmployeeService>();
            //services.AddScoped<IEmployeeRepository, EmployeeRepository>();

            //// Company Service
            //services.AddScoped<ICompanyService, CompanyService>();
            //services.AddScoped<ICompanyRepository, CompanyRepository>();

            //// Vehicle Service
            //services.AddScoped<IVehicleService, VehicleService>();
            //services.AddScoped<IVehicleRepository, VehicleRepository>();

            //// Shipment Service
            //services.AddScoped<IShipmentService, ShipmentService>();
            //services.AddScoped<IShipmentRepository, ShipmentRepository>();

            //// IncomeExpense Service
            //services.AddScoped<IIncomeExpenseService, IncomeExpenseService>();
            //services.AddScoped<IIncomeExpenseRepository, IncomeExpenseRepository>();

            //// IncomeExpense Service
            //services.AddScoped<IStatisticService, StatisticService>();

            //// Identity Service
            //services.AddScoped<IIdentityService, IdentityService>();

        }
    }
}
