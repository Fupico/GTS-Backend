using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GTSProject.Services.File.Entities
{

    public class UploadFile
    {
        [BsonId] // MongoDB için Id alanını birincil anahtar olarak belirtir
        [BsonRepresentation(BsonType.String)] // MongoDB'de Guid olarak saklamak için
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; } // Dosyanın depolandığı yerin yolu veya bağlantı stringi
        public string ContentType { get; set; }
        public long Size { get; set; }
        public string StorageProvider { get; set; } // MSSQL, MongoDB, AzureBlob gibi değerler alacak
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }


    }


}
