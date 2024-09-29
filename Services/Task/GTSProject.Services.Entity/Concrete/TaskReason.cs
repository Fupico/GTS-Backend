using GTSProject.Services.Core.Entities;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskReason : BaseEntity // Talep nedenlerini içerir.
    {
        public string Name { get; set; }

        #region İlişkiler
        public ICollection<KeywordToTaskReason> KeywordToTaskReasons { get; set; }
        public ICollection<Task> Tasks { get; set; }
        public ICollection<QuickAnswer> QuickAnswers { get; set; }
        #endregion
    }
}
