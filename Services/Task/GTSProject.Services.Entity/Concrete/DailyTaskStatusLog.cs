using GTSProject.Services.Core.Entity;

namespace GTSProject.Services.Entity.Concrete
{
    public class DailyTaskStatusLog : IEntity // Günlük talep durumlarının kayıtları içerir.
    {
        public int Id { get; set; }
        public DateTime TaskCreateDate { get; set; }
        public DateTime TaskUpdateDate { get; set; }

        #region İlişkiler
        public Guid TaskId { get; set; }
        public Task Task { get; set; }

        public Guid AssigneeId { get; set; } // User Idsi
        public int SprintId { get; set; } // Bununla ilgili class oluşturulacak

        public int StatusId { get; set; }
        public TaskStatus TaskStatus { get; set; }
        #endregion
    }
}
