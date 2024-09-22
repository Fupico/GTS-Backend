using GTSProject.Services.Core.Entities;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskRelation : BaseEntity // Talep ilişkilerini içerir.
    {
        public int Id { get; set; }

        #region İlişkiler
        public int TaskId1 { get; set; }
        public int TaskId2 { get; set; }
        public virtual Task Task { get; set; }

        public int UserId { get; set; } // User Id

        public int TaskRelationTypeId { get; set; }
        public virtual TaskRelationType TaskRelationType { get; set; }
        #endregion
    }
}
