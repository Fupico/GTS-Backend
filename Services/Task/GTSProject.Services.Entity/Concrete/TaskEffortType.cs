using GTSProject.Services.Core.Entity;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskEffortType : IEntity // Talep eforu tiplerini içerir.
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
    }
}
