using GTSProject.Services.Core.Entity;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskEffortType : IEntity // Talep eforu tiplerini içerir.
    {
        public int Id { get; set; }

        #region İlişkiler
        public int CategoryId { get; set; }
        public TaskCategory TaskCategory { get; set; }

        public ICollection<TaskEffort> TaskEfforts { get; set; }
        #endregion
    }
}
