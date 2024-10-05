
using GTSProject.Services.Business.Abstract;
using GTSProject.Services.Business.Concrete;
using GTSProject.Services.Core.Business.Abstract;
using GTSProject.Services.Core.UnitOfWork;
using GTSProject.Services.DataAccess.Abstract;
using GTSProject.Services.DataAccess.Concrete;
using GTSProject.Services.DataAccess.Concrete.EntityFramework;
using GTSProject.Services.Dto.TaskAutoAssignRuleDtos;
using GTSProject.Services.Dto.TaskDtos;
using GTSProject.Services.Entity.Concrete;
using GTSProject.Services.WebApi.Mapping;
using Microsoft.EntityFrameworkCore;
using Task = GTSProject.Services.Entity.Concrete.Task;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddDbContext<TaskServiceContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUnitOfWork<TaskServiceContext>, UnitOfWork<TaskServiceContext>>();
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

builder.Services.AddTransient<ITaskAutoAssignRuleService, TaskAutoAssignRuleManager>();
builder.Services.AddTransient<ITaskAutoAssignRuleDal, EfTaskAutoAssignRuleDal>();

builder.Services.AddScoped<IService<Task, CreateTaskDto, UpdateTaskDto, GetByIdTaskDto, ResultTaskDto>, TaskManager>();
builder.Services.AddScoped<IService<TaskAutoAssignRule, CreateTaskAutoAssignRuleDto, UpdateTaskAutoAssignRuleDto, GetByIdTaskAutoAssignRuleDto, ResultTaskAutoAssignRuleDto>, TaskAutoAssignRuleManager>();
builder.Services.AddTransient<ITaskService, TaskManager>();
builder.Services.AddTransient<ITaskDal, EfTaskDal>();

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
