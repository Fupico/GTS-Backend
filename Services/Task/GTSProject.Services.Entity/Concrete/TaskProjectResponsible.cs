namespace GTSProject.Services.Entity.Concrete
{
    public class TaskProjectResponsible // Talep sorumlularını tutar.
    {
        public int Id { get; set; }
        public int PropjectId { get; set; }
        public int CreatorId { get; set; }
        public int UserId { get; set; }
    }
}
