using GTSProject.Services.Core.Entity;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskWatcher : IEntity // Talep gözlemcilerini tutar. (Takip edenler)
    {
        public int Id { get; set; }
<<<<<<< HEAD
        public int TaskId { get; set; }
        public int WatcherId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
=======

        #region İlişkiler
        public Guid TaskId { get; set; }
        public Task Task { get; set; }

        public Guid UserId { get; set; } // Userdan atanan kişi idsi gelecek
        #endregion
>>>>>>> DB-Infrastractures
    }
}
