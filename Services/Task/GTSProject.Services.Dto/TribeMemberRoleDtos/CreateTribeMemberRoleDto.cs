using GTSProject.Services.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TribeMemberRoleDtos
{
    public class CreateTribeMemberRoleDto : BaseDto
    {
        public string Name { get; set; } // Rolün adı
        public string Tag { get; set; }  // Rol için etiket
    }
}
