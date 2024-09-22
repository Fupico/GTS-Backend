using GTSProject.Services.Core.Entities;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskRelationType : BaseEntity // Talep ilişkilerini içerir.(bu talep bununla ilgili gibi)
    {
        public int Id { get; set; }
        public string Name { get; set; }

        #region İlişkiler
        public ICollection<TaskRelation> TaskRelations { get; set; }
        #endregion 
    }
}
