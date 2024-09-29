using GTSProject.Services.Core.Entities;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskSubjectType : BaseEntity // Talep konu türlerini tutar.(Müşteri ilişkileri departmanı)
    {
        public string Name { get; set; }

        #region İlişkiler
        public ICollection<Task> Tasks { get; set; } 
        #endregion
    }
}
