using GTSProject.Services.Core.Entities;

namespace GTSProject.Services.Entity.Concrete
{
    public class QuickAnswer : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Answer { get; set; }

        #region İlişkiler
        public int TaskReasonId { get; set; }
        public virtual TaskReason TaskReason { get; set; }

        public int UserId { get; set; } // User Id

        public ICollection<TaskComment> TaskComments { get; set; }
        #endregion
    }
}
