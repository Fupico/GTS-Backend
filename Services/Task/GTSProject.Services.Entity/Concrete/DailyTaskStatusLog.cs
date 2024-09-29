using GTSProject.Services.Core.Entities;

namespace GTSProject.Services.Entity.Concrete
{
    public class DailyTaskStatusLog : BaseEntity // Günlük talep durumlarının kayıtları içerir.
    {
        public DateTime TaskCreateDate { get; set; }
        public DateTime TaskUpdateDate { get; set; }

        #region İlişkiler
        public int TaskId { get; set; }
        public virtual Task Task { get; set; }

        public int AssigneeId { get; set; } // User Id

        public int SprintId { get; set; }
        public Sprint Sprint { get; set; }

        public int TaskStatusId { get; set; }
        public virtual TaskStatus TaskStatus { get; set; }
        #endregion
    }
}
