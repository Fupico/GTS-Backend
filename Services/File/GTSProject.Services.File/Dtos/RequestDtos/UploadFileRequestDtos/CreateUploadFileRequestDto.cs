namespace GTSProject.Services.File.Dtos.RequestDtos.UploadFileRequestDtos
{
    public class CreateUploadFileRequestDto
    {
        public string StorageProvider { get; set; } //mssql //mongodb
        public IFormFile FormFile { get; set; }
    }
}
