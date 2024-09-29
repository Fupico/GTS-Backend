using GTSProject.Services.Core.Entities;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskCategory : BaseEntity // Departman talep kategorilerini içerir.
    {
        public string? Name { get; set; }
        public int Group { get; set; }
        public string? GroupName { get; set; }
        public int Status { get; set; }

        #region İlişkiler
        public int? ParentId { get; set; }
        public virtual TaskCategory? ParentTaskCategory { get; set; }

        public ICollection<KeywordToTaskReason> KeywordToTaskReasons { get; set; }
        public ICollection<Task> Tasks { get; set; }
        public ICollection<TaskEffortType> TaskEffortTypes { get; set; }
        #endregion
    }
}
