namespace GTSProject.Services.Entity.Concrete
{
    public class KeywordToTaskReason // Konu başlığına girilen anahtar kelimeleri tutar.
    {
        public int Id { get; set; }
        public string Keyword { get; set; }

        #region İlişkiler
        public int CategoryId { get; set; }
        public TaskCategory TaskCategory { get; set; }

        public int ReasonId { get; set; }
        public TaskReason TaskReason { get; set; }
        #endregion
    }
}
