namespace GTSProject.Services.Entity.Concrete
{
    public class TaskComment // Talep yönetimi,talep yorumlarını tutar.
    {
        public Guid Id { get; set; }
        public string? Message { get; set; }
        public bool HasAttachment { get; set; }
        public bool ShowToAllUser { get; set; }

        #region İlişkiler
        public Guid TaskId { get; set; }
        public Task Task { get; set; }

        public Guid UserId { get; set; } // User servisten gelecek

        public int QuickAnswerId { get; set; } // Sınıfı eklenecek

        public ICollection<TaskAttachment> TaskAttachments { get; set; }
        #endregion
    }
}
