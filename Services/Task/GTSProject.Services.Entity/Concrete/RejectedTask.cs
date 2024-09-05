namespace GTSProject.Services.Entity.Concrete
{
    public class RejectedTask // Reddedilen Talepler hakkındaki bilgileri içerir.
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        #region İlişkiler
        public int TaskId { get; set; }
        public Task Task { get; set; }
        #endregion
    }
}
