using GTSProject.Services.Core.Entity;

namespace GTSProject.Services.Entity.Concrete
{
    public class RejectedTask : IEntity // Reddedilen Talepler hakkındaki bilgileri içerir.
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        #region İlişkiler
        public int TaskId { get; set; }
        public Task Task { get; set; }
        #endregion
    }
}
