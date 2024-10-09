using GTSProject.Services.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskTypeDtos
{
    public class CreateTaskTypeDto : BaseEntity
    {
        public string Name { get; set; } // Talep tipinin adı
        public string Color { get; set; } // Talep tipinin rengi
    }
}
