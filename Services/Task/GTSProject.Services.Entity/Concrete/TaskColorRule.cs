using GTSProject.Services.Core.Entities;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskColorRule : BaseEntity // Talep yönetimi, otomatik atanan renk kurallarını içerir. 
    {
        public string? Key { get; set; }
        public string? Value { get; set; }
        public string? Color { get; set; }
    }
}
