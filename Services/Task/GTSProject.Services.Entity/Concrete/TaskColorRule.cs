using GTSProject.Services.Core.Entity;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskColorRule : IEntity // Talep yönetimi, otomatik atanan renk kurallarını içerir.
    {
        public int Id { get; set; }
        public string? Key { get; set; }
        public string? Value { get; set; }
        public string? Color { get; set; }
    }
}
