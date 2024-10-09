using GTSProject.Services.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskRelationDtos
{
    public class CreateTaskRelationDto : BaseDto
    {
        public int TaskId1 { get; set; }  // İlk ilişkilendirilmiş görev
        public int TaskId2 { get; set; }  // İkinci ilişkilendirilmiş görev
        public int UserId { get; set; }   // Kullanıcı Id (İlişkiyi ekleyen kişi)
        public int TaskRelationTypeId { get; set; }  // İlişki tipi Id
    }
}
