using GTSProject.Services.Core.Entities;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskStatus : BaseEntity // Talep durumlarını içerir. (statüleri)
    {
        public string Tag { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Order { get; set; }

        #region İlişkiler
        public ICollection<DailyTaskStatusLog> DailyTaskStatusLogs { get; set; }
        public ICollection<Task> Tasks { get; set; }
        public ICollection<TaskHistory> TaskHistories { get; set; }
        #endregion
    }
}
