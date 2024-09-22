using GTSProject.Services.Core.Entities;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskComment : BaseEntity // Talep yönetimi,talep yorumlarını tutar.
    {
        public int Id { get; set; }
        public string? Message { get; set; }
        public bool HasAttachment { get; set; }
        public bool ShowToAllUser { get; set; }

        #region İlişkiler
        public int TaskId { get; set; }
        public virtual Task Task { get; set; }

        public int UserId { get; set; } // User Id

        public int QuickAnswerId { get; set; }
        public virtual QuickAnswer QuickAnswer { get; set; }

        public ICollection<TaskAttachment> TaskAttachments { get; set; }
        #endregion
    }
}
