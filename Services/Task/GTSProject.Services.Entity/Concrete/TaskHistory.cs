using GTSProject.Services.Core.Entities;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskHistory : BaseEntity // Talebin tüm loglarını içerir.
    {
        public int Id { get; set; }
        public string Message { get; set; }

        #region İlişkiler
        public int TaskId { get; set; }
        public virtual Task Task { get; set; }

        public int UserId { get; set; } // User Id

        public int TaskStatusId { get; set; }
        public virtual TaskStatus TaskStatus { get; set; }
        #endregion
    }
}
