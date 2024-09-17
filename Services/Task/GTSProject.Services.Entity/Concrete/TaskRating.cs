using GTSProject.Services.Core.Entities;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskRating : BaseEntity // Talep değerlendirmelerini tutar.
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public string Note { get; set; }

        #region İlişkiler
        public int TaskId { get; set; }
        public virtual Task Task { get; set; }

        public int UserId { get; set; } // User Id
        public int AssigneeId { get; set; } // User Id

        public int CategoryId { get; set; }
        public virtual TaskCategory TaskCategory { get; set; }
        #endregion
    }
}
