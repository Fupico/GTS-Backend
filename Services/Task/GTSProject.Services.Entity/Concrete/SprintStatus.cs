using GTSProject.Services.Core.Entities;

namespace GTSProject.Services.Entity.Concrete
{
    public class SprintStatus : BaseEntity
    {
        public string Name { get; set; }
        public string Tag { get; set; }
        public string Color { get; set; }
        public int OrderNumber { get; set; }

        #region İlişkiler
        public ICollection<Sprint> Sprints { get; set; }
        #endregion
    }
}
