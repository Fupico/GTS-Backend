using GTSProject.Services.Core.Entities;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskAutoAssignRule : BaseEntity // Otomatik talep atama kurallarını tutar.
    {
        public string? RuleType { get; set; }
        public string? Key { get; set; }
        public string? Value { get; set; }
        public string? Key2 { get; set; }
        public string? Value2 { get; set; }
        public string? Key3 { get; set; }
        public string? Value3 { get; set; }
        public string? Key4 { get; set; }
        public string? Value4 { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

        #region İlişkiler
        public int? AssigneeId { get; set; } // User Id
        #endregion
    }
}
