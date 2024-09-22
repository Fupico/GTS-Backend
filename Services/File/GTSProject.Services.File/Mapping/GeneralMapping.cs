using AutoMapper;
using GTSProject.Services.File.Dtos.RequestDtos.UploadFileRequestDtos;
using GTSProject.Services.File.Dtos.UploadFileDtos;
using GTSProject.Services.File.Entities;

namespace GTSProject.Services.File.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {

            CreateMap<IFormFile, CreateUploadFileRequestDto>()
    .ForMember(dest => dest.StorageProvider, opt => opt.Ignore())
    .ForMember(dest => dest.FormFile, opt => opt.MapFrom(src => src));

            CreateMap<UploadFile, CreateUploadFileDto>().ReverseMap();
            CreateMap<UploadFile, ResultUploadFileDto>().ReverseMap();
            CreateMap<UploadFile, GetByIdUploadFileDto>().ReverseMap();
            CreateMap<UploadFile, UpdateUploadFileDto>().ReverseMap();
        }
    }
}
