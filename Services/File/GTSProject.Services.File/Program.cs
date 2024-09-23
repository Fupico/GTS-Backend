using GTSProject.Services.File.DbSettings.Concrete;
using GTSProject.Services.File.Repositories.RepositoryFactories;
using GTSProject.Services.File.Repositories.UploadFileRepositories;
using GTSProject.Services.File.Services.UploadFileServices;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
// MSSQL Configuration
builder.Services.AddDbContext<MssqlDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MSSQL")));

// MongoDB Configuration
builder.Services.AddSingleton<MongoDbContext>(sp =>
{
    var configuration = sp.GetRequiredService<IConfiguration>();
    return new MongoDbContext(configuration);
});
builder.Services.AddScoped<IUploadFileService, UploadFileService>();
//builder.Services.AddScoped<IUploadFileRepository, MongoUploadFileRepository>();
//builder.Services.AddScoped<IUploadFileRepository, MssqlUploadFileRepository>();
builder.Services.AddScoped<MssqlUploadFileRepository>();
builder.Services.AddScoped<MongoUploadFileRepository>();
builder.Services.AddScoped<IRepositoryFactory, RepositoryFactory>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
