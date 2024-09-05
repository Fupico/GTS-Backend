namespace GTSProject.Services.Entity.Concrete
{
    public class TaskReason // Talep nedenlerini içerir.
    {
        public int Id { get; set; }
        public string Name { get; set; }

        #region İlişkiler
        public ICollection<KeywordToTaskReason> KeywordToTaskReasons { get; set; }
        public ICollection<Task> Tasks { get; set; }
        #endregion
    }
}
