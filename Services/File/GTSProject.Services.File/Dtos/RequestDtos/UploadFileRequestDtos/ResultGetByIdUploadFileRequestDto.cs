namespace GTSProject.Services.File.Dtos.RequestDtos.UploadFileRequestDtos
{
    public class ResultGetByIdUploadFileRequestDto
    {
        public Guid Id { get; set; }
        public string StorageProvider { get; set; } //mssql //mongodb
    }
}
