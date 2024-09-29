namespace GTSProject.Services.File.Dtos.RequestDtos.UploadFileRequestDtos
{
    public class DeleteUploadFileRequestDto
    {
        public Guid Id { get; set; }
        public string StorageProvider { get; set; } //mssql //mongodb
    }
}
