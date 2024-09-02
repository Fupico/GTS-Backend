using GTSProject.Services.Core.Entity;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskAttachment : IEntity // Talepte eklenmiş dosyaları tutar.
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int CommentId { get; set; }
        public int UserId { get; set; }
        public string? FolderName { get; set; }
        public string? FileName { get; set; }
        public bool AgencyCanView { get; set; }
        public bool ShowOnlyToDepartment { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
