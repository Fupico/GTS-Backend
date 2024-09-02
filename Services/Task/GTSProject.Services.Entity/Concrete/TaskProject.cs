using GTSProject.Services.Core.Entity;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskProject : IEntity // Talep projelerini içerir.
    {
        public int Id { get; set; }
        public int OwnerId { get; set; }
    }
}
