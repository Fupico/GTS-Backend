using GTSProject.Services.Core.Entity;

namespace GTSProject.Services.Entity.Concrete
{
<<<<<<< HEAD
    public class TaskRelationType // Talep ilişkilerini içerir.
=======
    public class TaskRelationType : IEntity // Talep ilişkilerini içerir.(bu talep bununla ilgili gibi)
>>>>>>> DB-Infrastractures
    {
        public int Id { get; set; }
        public string Name { get; set; }

<<<<<<< HEAD
        public ICollection<TaskRelation> TaskRelations { get; set; }
=======
        #region İlişkiler
        public ICollection<TaskRelation> TaskRelations { get; set; }
        #endregion
>>>>>>> DB-Infrastractures
    }
}
