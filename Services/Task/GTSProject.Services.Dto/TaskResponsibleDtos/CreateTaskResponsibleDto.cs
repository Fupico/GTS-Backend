using GTSProject.Services.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskResponsibleDtos
{
    public class CreateTaskResponsibleDto : BaseDto
    {
        public int TaskId { get; set; } // İlgili talep ID'si
        public int UserId { get; set; } // Sorumlu kullanıcı ID'si
        public int CreatorUserId { get; set; } // Oluşturan kullanıcı ID'si
    }
}
