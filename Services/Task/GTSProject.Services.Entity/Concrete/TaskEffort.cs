using GTSProject.Services.Core.Entities;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskEffort : BaseEntity // Talep eforlarını içerir.
    {
        public int Id { get; set; }
        public int Effort { get; set; }
        public string Description { get; set; }
        public int ConfirmedEffort { get; set; }
        public string ConfirmedMessage { get; set; }

        #region İlişkiler
        public int TaskId { get; set; }
        public virtual Task Task { get; set; }

        public int UserId { get; set; } // User Id
        public int ConfirmedByUserId { get; set; } // User Id

        public int TaskEffortTypeId { get; set; }
        public virtual TaskEffortType TaskEffortType { get; set; }
        #endregion
    }
}
