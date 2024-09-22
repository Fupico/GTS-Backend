using GTSProject.Services.Core.Entities;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskType : BaseEntity // Talep tiplerini içerir.
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        #region İlişkiler
        public ICollection<Task> Tasks { get; set; } 
        #endregion
    }
}
