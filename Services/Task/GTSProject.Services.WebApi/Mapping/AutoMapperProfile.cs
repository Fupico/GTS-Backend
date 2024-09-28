using AutoMapper;
using GTSProject.Services.Dto.TaskAutoAssignRuleDtos;
using GTSProject.Services.Entity.Concrete;

namespace GTSProject.Services.WebApi.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<TaskAutoAssignRule, CreateTaskAutoAssignRuleDto>().ReverseMap();
            CreateMap<TaskAutoAssignRule, GetByIdTaskAutoAssignRuleDto>().ReverseMap();
            CreateMap<TaskAutoAssignRule, ResultTaskAutoAssignRuleDto>().ReverseMap();
            CreateMap<TaskAutoAssignRule, UpdateTaskAutoAssignRuleDto>().ReverseMap();
        }
    }
}
