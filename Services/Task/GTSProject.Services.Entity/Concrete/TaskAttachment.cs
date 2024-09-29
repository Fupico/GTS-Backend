using GTSProject.Services.Core.Entities;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskAttachment : BaseEntity // Talepte eklenmiş dosyaları tutar.
    {
        public string? FolderName { get; set; }
        public string? FileName { get; set; }
        public bool ShowToAllUser { get; set; }

        #region İlişkiler
        public int TaskId { get; set; }
        public virtual Task Task { get; set; }

        public int TaskCommentId { get; set; }
        public virtual TaskComment TaskComment { get; set; }

        public int UserId { get; set; } // User Id
        #endregion
    }
}
