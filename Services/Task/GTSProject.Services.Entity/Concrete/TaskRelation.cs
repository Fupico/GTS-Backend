using GTSProject.Services.Core.Entity;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskRelation : IEntity // Talep ilişkilerini içerir.
    {
        public int Id { get; set; }

        #region İlişkiler
        public int TaskId1 { get; set; }
        public int TaskId2 { get; set; }
        public Task Task { get; set; }

        public int UserId { get; set; } // User servisten gelecek


        public int RelationTypeId { get; set; }
        public TaskRelationType TaskRelationType { get; set; }
        #endregion
    }
}
