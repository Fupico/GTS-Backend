using GTSProject.Services.Core.Entity;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskProject : IEntity // Talep projelerini içerir.
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool ShowToAllUser { get; set; }

        #region İlişkiler
        public ICollection<Task> Tasks { get; set; }
        #endregion
    }
}
