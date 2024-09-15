using GTSProject.Services.Core.Entity;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskType : IEntity // Talep tiplerini içerir.
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        #region İlişkiler
        public ICollection<Task> Tasks { get; set; }
        #endregion
    }
}
