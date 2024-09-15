using GTSProject.Services.Core.Entity;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskAttachment : IEntity // Talepte eklenmiş dosyaları tutar.
    {
        public int Id { get; set; }
        public string? FolderName { get; set; }
        public string? FileName { get; set; }
        public bool ShowToAllUser { get; set; }

        #region İlişkiler
        public Guid TaskId { get; set; }
        public Task Task { get; set; }

        public int CommentId { get; set; }
        public TaskComment TaskComment { get; set; }

        public Guid UserId { get; set; } // User servisten gelecek
        #endregion
    }
}
