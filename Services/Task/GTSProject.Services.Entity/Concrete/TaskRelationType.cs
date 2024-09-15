using GTSProject.Services.Core.Entity;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskRelationType : IEntity // Talep ilişkilerini içerir.(bu talep bununla ilgili gibi)
    {
        public int Id { get; set; }
        public string Name { get; set; }

        #region İlişkiler
        public ICollection<TaskRelation> TaskRelations { get; set; }
        #endregion
    }
}
