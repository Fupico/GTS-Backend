using GTSProject.Services.Entity.Concrete;

namespace GTSProject.Services.Entity.Concrete
{
    public class DailyTaskStatusLog // Günlük talep durumlarının kayıtları içerir.
    {
        public int Id { get; set; }
        public DateTime TaskCreateDate { get; set; }
        public DateTime TaskUpdateDate { get; set; }

        #region İlişkiler
        public Guid TaskId { get; set; }
        public Task Task { get; set; }

        public Guid AssigneeId { get; set; } // User Idsi

        public int StatusId { get; set; }
        public TaskStatus TaskStatus { get; set; }
        #endregion
    }
}
