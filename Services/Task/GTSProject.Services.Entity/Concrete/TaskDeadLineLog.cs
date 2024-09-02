using GTSProject.Services.Core.Entity;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskDeadLineLog : IEntity // Talep yönetimi,talep son teslim tarihi loglarını tutar.
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public DateTime DeadLine { get; set; }
        public string? Description { get; set; }
        public int UserId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
