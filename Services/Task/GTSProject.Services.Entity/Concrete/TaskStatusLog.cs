using GTSProject.Services.Core.Entities;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskStatusLog : BaseEntity // Talep durum kayıtlarını tutar.
    {
        public string Description { get; set; }

        #region İlişkiler
        public int TaskId { get; set; }
        public virtual Task Task { get; set; }

        public int TaskStatusId { get; set; }
        public virtual TaskStatus TaskStatus { get; set; }

        public int AssigneeId { get; set; } // User Id
        public int UserId { get; set; } // User Id
        #endregion
    }
}
