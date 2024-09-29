using GTSProject.Services.Core.Entities;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskWatcher : BaseEntity // Talep gözlemcilerini tutar. (Takip edenler)
    {
        #region İlişkiler
        public int TaskId { get; set; }
        public virtual Task Task { get; set; }

        public int UserId { get; set; } // User Id
        public int WatcherId { get; set; } // User Id
        #endregion
    }
}
