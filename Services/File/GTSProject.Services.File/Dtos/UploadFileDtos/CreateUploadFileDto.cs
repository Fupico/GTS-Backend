namespace GTSProject.Services.File.Dtos.UploadFileDtos
{
    public class CreateUploadFileDto
    {
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public long Size { get; set; }
        public string StorageProvider { get; set; } // MSSQL, MongoDB, AzureBlob gibi değerler alacak
        public string FilePath { get; set; } // Dosyanın depolandığı yerin yolu veya bağlantı stringi
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
    }
}
