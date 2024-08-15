namespace GTSProject.Services.Entity.Concrete
{
    public class RejectedTask // Reddedilen Talepler hakkındaki bilgileri içerir.
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int UserId { get; set; }
    }
}
