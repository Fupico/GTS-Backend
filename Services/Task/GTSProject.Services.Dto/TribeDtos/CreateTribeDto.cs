using GTSProject.Services.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TribeDtos
{
    public class CreateTribeDto : BaseDto
    {
        public string Name { get; set; } // Tribe adı
        public int TaskProjectId { get; set; } // İlişkili görev projesinin ID'si
    }
}
