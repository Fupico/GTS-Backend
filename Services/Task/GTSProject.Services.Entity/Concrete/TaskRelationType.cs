namespace GTSProject.Services.Entity.Concrete
{
    public class TaskRelationType // Talep ilişkilerini içerir.
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<TaskRelation> TaskRelations { get; set; }
    }
}
