using GTSProject.Services.Core.Entity;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskStatusLog : IEntity // Talep durum kayıtlarını tutar.
    {
        public int Id { get; set; }
        public string Description { get; set; }

        #region İlişkiler
        public Guid TaskId { get; set; }
        public Task Task { get; set; }

        public int StatusId { get; set; }
        public TaskStatus TaskStatus { get; set; }

        public Guid AssigneeId { get; set; } // Userdan atayan kişi idsi gelecek
        public Guid UserId { get; set; } // Userdan atayan kişi idsi gelecek
        #endregion
    }
}
