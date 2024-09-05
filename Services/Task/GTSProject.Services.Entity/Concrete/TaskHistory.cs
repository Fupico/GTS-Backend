namespace GTSProject.Services.Entity.Concrete
{
    public class TaskHistory // Talebin tüm loglarını içerir.
    {
        public int Id { get; set; }

        #region İlişkiler
        public Guid TaskId { get; set; }
        public Task Task { get; set; }

        public Guid UserId { get; set; } // User servisten gelecek

        public int StatusId { get; set; }
        public TaskStatus TaskStatus { get; set; }
        #endregion
    }
}
