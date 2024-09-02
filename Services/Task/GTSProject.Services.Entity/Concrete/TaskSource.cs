namespace GTSProject.Services.Entity.Concrete
{
    public class TaskSource // Talep kaynağını içerir.
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
