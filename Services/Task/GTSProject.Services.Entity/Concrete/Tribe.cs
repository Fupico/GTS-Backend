using GTSProject.Services.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Entity.Concrete
{
    public class Tribe : BaseEntity
    {
        public string Name { get; set; }

        #region İlişkiler
        public int TaskProjectId { get; set; }
        public virtual TaskProject TaskProject { get; set; }

        public ICollection<Sprint> Sprints { get; set; }
        public ICollection<TribeMember> TribeMembers { get; set; }
        #endregion
    }
}
