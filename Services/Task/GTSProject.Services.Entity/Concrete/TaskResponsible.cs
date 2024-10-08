using GTSProject.Services.Core.Entities;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskResponsible : BaseEntity // Talep sorumluluklarını tutar.
    {
        #region İlişkiler
        public int TaskId { get; set; }
        public virtual Task Task { get; set; }

        public int UserId { get; set; } // User Id
        public int CreatorUserId { get; set; } // User Id
        #endregion
    }
}
