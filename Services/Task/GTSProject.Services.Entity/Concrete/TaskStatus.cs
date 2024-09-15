using GTSProject.Services.Core.Entity;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskStatus : IEntity // Talep durumlarını içerir. (statüleri)
    {
        public int Id { get; set; }
<<<<<<< HEAD
        public int KanbanStatusId { get; set; }
        public string Tag { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Order { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
=======
        public string Tag { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
>>>>>>> DB-Infrastractures

        #region İlişkiler
        public ICollection<DailyTaskStatusLog> DailyTaskStatusLogs { get; set; }
        public ICollection<Task> Tasks { get; set; }
        public ICollection<TaskHistory> TaskHistories { get; set; }
        #endregion
    }
}
