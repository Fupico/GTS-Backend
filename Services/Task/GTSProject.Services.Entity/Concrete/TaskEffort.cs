using GTSProject.Services.Core.Entity;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskEffort : IEntity // Talep eforlarını içerir.
    {
        public int Id { get; set; }
        public int Effort { get; set; }
        public string Description { get; set; }

        #region İlişkiler
        public int TaskId { get; set; }
        public Task Task { get; set; }

        public int UserId { get; set; } // User servisten gelecek
        public int ConfirmedByUserId { get; set; } // User servisten gelecek

        public int TaskEffortTypeId { get; set; }
        public TaskEffortType TaskEffortType { get; set; }
        #endregion
    }
}
