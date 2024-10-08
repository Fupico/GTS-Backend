using GTSProject.Services.Core.Entities;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskDeadLineLog : BaseEntity // Talep yönetimi,talep son teslim tarihi loglarını tutar.
    {
        public DateTime DeadLine { get; set; }
        public string? Description { get; set; }

        #region İlişkiler
        public int TaskId { get; set; }
        public virtual Task Task { get; set; }

        public int UserId { get; set; } // User Id
        #endregion
    }
}
