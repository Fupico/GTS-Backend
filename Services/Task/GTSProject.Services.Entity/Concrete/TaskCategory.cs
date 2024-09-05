namespace GTSProject.Services.Entity.Concrete
{
    public class TaskCategory // Departman talep kategorilerini içerir.
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Group { get; set; }
        public string? GroupName { get; set; }

        #region İlişkiler
        public int ParentId { get; set; } // Üst kategori

        public ICollection<KeywordToTaskReason> KeywordToTaskReasons { get; set; }
        public ICollection<Task> Tasks { get; set; }
        public ICollection<TaskEffortType> TaskEffortTypes { get; set; }
        #endregion
    }
}
