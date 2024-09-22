using GTSProject.Services.Core.Entities;

namespace GTSProject.Services.Entity.Concrete
{
    public class KeywordToTaskReason : BaseEntity  // Konu başlığına girilen anahtar kelimeleri tutar.
    {
        public int Id { get; set; }
        public string Keyword { get; set; }

        #region İlişkiler
        public int TaskCategoryId { get; set; }
        public virtual TaskCategory TaskCategory { get; set; }

        public int TaskReasonId { get; set; }
        public virtual TaskReason TaskReason { get; set; }
        #endregion 
    }
}
