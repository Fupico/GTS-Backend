using GTSProject.Services.Core.Entities;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskProject : BaseEntity // Talep projelerini içerir.
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public bool ShowToAllUser { get; set; }

        #region İlişkiler
        public Guid OwnerId { get; set; } // User Id

        public ICollection<Task> Tasks { get; set; }
        public ICollection<Sprint> Sprints { get; set; }
        public ICollection<Tribe> Tribes { get; set; }
        #endregion
    }
}
