using GTSProject.Services.Core.Entity;

namespace GTSProject.Services.Entity.Concrete
{
<<<<<<< HEAD
    public class TaskDeadLineLog // Talep yönetimi, talep son teslim tarihi loglarını tutar.
=======
    public class TaskDeadLineLog : IEntity // Talep yönetimi,talep son teslim tarihi loglarını tutar.
>>>>>>> DB-Infrastractures
    {
        public int Id { get; set; }
        public DateTime DeadLine { get; set; }
        public string? Description { get; set; }

        #region İlişkiler
        public Guid TaskId { get; set; }
        public Task Task { get; set; }

        public Guid UserId { get; set; } // User servisten gelecek
        #endregion
    }
}
