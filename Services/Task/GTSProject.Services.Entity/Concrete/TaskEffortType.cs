using GTSProject.Services.Core.Entities;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskEffortType : BaseEntity // Talep eforu tiplerini içerir.
    {
        public int Id { get; set; }

        #region İlişkiler
        public int TaskCategoryId { get; set; }
        public virtual TaskCategory TaskCategory { get; set; }

        public ICollection<TaskEffort> TaskEfforts { get; set; }
        #endregion
    }
}
