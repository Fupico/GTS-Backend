using GTSProject.Services.Core.Entity;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskReason : IEntity // Talep nedenlerini içerir.
    {
        public int Id { get; set; }
<<<<<<< HEAD
=======
        public int ProductId { get; set; }
>>>>>>> DB-Infrastractures
        public string Name { get; set; }

        #region İlişkiler
        public ICollection<KeywordToTaskReason> KeywordToTaskReasons { get; set; }
<<<<<<< HEAD
        public ICollection<Task> Tasks { get; set; }
=======
>>>>>>> DB-Infrastractures
        #endregion
    }
}
