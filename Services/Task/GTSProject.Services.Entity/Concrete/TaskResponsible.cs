using GTSProject.Services.Core.Entity;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskResponsible : IEntity // Talep sorumluluklarını tutar.
    {
        public int Id { get; set; }

        #region İlişkiler
        public int TaskId { get; set; }
        public Task Task { get; set; }

        public int UserId { get; set; } // Userdan atayan kişi idsi gelecek
        public int CreatorUserId { get; set; } // Userdan atayan kişi idsi gelecek
        #endregion
    }
}
