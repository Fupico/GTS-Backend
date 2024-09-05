namespace GTSProject.Services.Entity.Concrete
{
    public class TaskRelation // Talep ilişkilerini içerir.
    {
        public int Id { get; set; }

        #region İlişkiler
        public Guid TaskId1 { get; set; }
        public Task Task1 { get; set; }

        public Guid UserId { get; set; } // User servisten gelecek

        public Guid TaskId2 { get; set; }
        public Task Task2 { get; set; }

        public int RelationTypeId { get; set; }
        public TaskRelationType TaskRelationType { get; set; }
        #endregion
    }
}
