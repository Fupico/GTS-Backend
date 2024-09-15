using GTSProject.Services.Core.Entity;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskComment : IEntity // Talep yönetimi,talep yorumlarını tutar.
    {
        public int Id { get; set; }
        public string? Message { get; set; }
        public bool HasAttachment { get; set; }
        public bool ShowToAllUser { get; set; }

        #region İlişkiler
        public int TaskId { get; set; }
        public Task Task { get; set; }

        public int UserId { get; set; } // User servisten gelecek

        public int QuickAnswerId { get; set; } // Sınıfı eklenecek

        public ICollection<TaskAttachment> TaskAttachments { get; set; }
        #endregion
    }
}
