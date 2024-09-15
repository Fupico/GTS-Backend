using GTSProject.Services.Core.Entity;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskSubjectType : IEntity // Talep konu türlerini tutar.(Müşteri ilişkileri departmanı)
    {
        public int Id { get; set; }
        public string Name { get; set; }
<<<<<<< HEAD
        public string SlaGroup { get; set; }
=======
>>>>>>> DB-Infrastractures

        #region İlişkiler
        public ICollection<Task> Tasks { get; set; }
        #endregion
    }
}
