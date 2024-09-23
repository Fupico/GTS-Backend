namespace GTSProject.Services.File.Dtos.RequestDtos.UploadFileRequestDtos
{
    public class CreateMultipleUploadFileRequestDto
    {
        public string StorageProvider { get; set; } //mssql //mongodb
        public List<IFormFile> FormFiles { get; set; }
    }
}
