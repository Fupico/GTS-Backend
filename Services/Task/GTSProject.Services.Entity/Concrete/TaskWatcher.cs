using GTSProject.Services.Core.Entity;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskWatcher : IEntity // Talep gözlemcilerini tutar. (Takip edenler)
    {
        public int Id { get; set; }

        #region İlişkiler
        public int TaskId { get; set; }
        public Task Task { get; set; }

        public int UserId { get; set; } // Userdan atanan kişi idsi gelecek
        #endregion
    }
}
