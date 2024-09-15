using GTSProject.Services.Core.Entity;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskStatusLog : IEntity // Talep durum kayıtlarını tutar.
    {
        public int Id { get; set; }
        public string Description { get; set; }

        #region İlişkiler
        public int TaskId { get; set; }
        public Task Task { get; set; }

        public int TaskStatusId { get; set; }
        public TaskStatus TaskStatus { get; set; }

        public int AssigneeId { get; set; } // Userdan atayan kişi idsi gelecek
        public int UserId { get; set; } // Userdan atayan kişi idsi gelecek
        #endregion
    }
}
