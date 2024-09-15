using GTSProject.Services.Core.Entity;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskReason : IEntity // Talep nedenlerini içerir.
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }

        #region İlişkiler
        public ICollection<KeywordToTaskReason> KeywordToTaskReasons { get; set; }
        #endregion
    }
}
