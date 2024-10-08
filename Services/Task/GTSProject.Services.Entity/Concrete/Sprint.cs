using GTSProject.Services.Core.Entities;

namespace GTSProject.Services.Entity.Concrete
{
    public class Sprint : BaseEntity
    {
        public string Name { get; set; }
        public int StartDateWeekNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        #region İlişkiler
        public int TaskProjectId { get; set; }
        public virtual TaskProject TaskProject { get; set; }

        public int TribeId { get; set; }
        public virtual Tribe Tribe { get; set; }

        public int SprintStatusId { get; set; }
        public virtual SprintStatus SprintStatus { get; set; }

        public ICollection<DailyTaskStatusLog> DailyTaskStatusLogs { get; set; }
        #endregion
    }
}
