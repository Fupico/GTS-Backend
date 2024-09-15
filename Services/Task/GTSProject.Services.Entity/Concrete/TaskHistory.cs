using GTSProject.Services.Core.Entity;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskHistory : IEntity // Talebin tüm loglarını içerir.
    {
        public int Id { get; set; }

        #region İlişkiler
        public int TaskId { get; set; }
        public Task Task { get; set; }

        public int UserId { get; set; } // User servisten gelecek

        public int TaskStatusId { get; set; }
        public TaskStatus TaskStatus { get; set; }
        #endregion
    }
}
