using GTSProject.Services.Core.Entities;

namespace GTSProject.Services.Entity.Concrete
{
    public class TribeMemberRole : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tag { get; set; }

        #region İlişkiler
        public ICollection<TribeMember> TribeMembers { get; set; }
        #endregion
    }
}
