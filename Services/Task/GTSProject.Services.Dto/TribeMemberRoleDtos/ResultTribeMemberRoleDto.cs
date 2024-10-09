using GTSProject.Services.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TribeMemberRoleDtos
{
    public class ResultTribeMemberRoleDto : BaseDto
    {
        public int Id { get; set; }
        public string Name { get; set; } // Rolün adı
        public string Tag { get; set; }  // Rol için etiket
    }
}
