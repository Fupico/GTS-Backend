namespace GTSProject.Services.Entity.Concrete
{
    public class TaskSlaLog // Talep sla kayıtlarını tutar.
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int StatusId { get; set; }
        public int UserId { get; set; }
    }
}
