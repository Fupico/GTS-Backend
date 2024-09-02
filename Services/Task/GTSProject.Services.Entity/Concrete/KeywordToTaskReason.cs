using GTSProject.Services.Core.Entity;

namespace GTSProject.Services.Entity.Concrete
{
    public class KeywordToTaskReason : IEntity  // Konu başlığına girilen anahtar kelimeleri tutar.
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int ProductId { get; set; }
        public string? Keyword { get; set; }
        public int ReasonId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
