using GTSProject.Services.Core.Entity;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskCategory : IEntity // Departman talep kategorilerini içerir.
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Group { get; set; }
        public string? GroupName { get; set; }
<<<<<<< HEAD

        #region İlişkiler
        public int ParentId { get; set; } // Üst kategori

        public ICollection<KeywordToTaskReason> KeywordToTaskReasons { get; set; }
        public ICollection<Task> Tasks { get; set; }
        public ICollection<TaskEffortType> TaskEffortTypes { get; set; }
=======
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

        #region İlişkiler
        public ICollection<KeywordToTaskReason> KeywordToTaskReasons { get; set; }
>>>>>>> DB-Infrastractures
        #endregion
    }
}
