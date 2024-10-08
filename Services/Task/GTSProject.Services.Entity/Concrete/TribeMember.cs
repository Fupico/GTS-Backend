using GTSProject.Services.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Entity.Concrete
{
    public class TribeMember : BaseEntity
    {
        #region İlişkiler
        public int TribeId { get; set; }
        public virtual Tribe Tribe { get; set; }

        public int UserId { get; set; } // User Id

        public int TribeMemberRoleId { get; set; }
        public virtual TribeMemberRole TribeMemberRole { get; set; }
        #endregion

    }
}
