using GTSProject.Services.Core.Entity;

namespace GTSProject.Services.Task.Models.Entities
{
    public class DailyTaskStatusLog : IEntity // Günlük talep durumlarının kayıtları içerir.
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int StatusId { get; set; }
        public int AssigneeId { get; set; }
        public DateTime TaskCreateDate { get; set; }
        public DateTime TaskUpdateDate { get; set; }
        public int SprintId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
