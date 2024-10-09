using GTSProject.Services.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TribeMemberDtos
{
    public class CreateTribeMemberDto : BaseDto
    {
        public int TribeId { get; set; } // İlişkili Tribe'ın ID'si
        public int UserId { get; set; } // Kullanıcı ID'si
        public int TribeMemberRoleId { get; set; } // Tribe üyesinin rol ID'si
    }
}
