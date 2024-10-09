using GTSProject.Services.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskStatus
{
    public class UpdateTaskStatusDto : BaseDto
    {
        public int Id { get; set; }
        public string Tag { get; set; } // Statü etiketi
        public string Name { get; set; } // Statü adı
        public string Color { get; set; } // Statü rengi
        public int Order { get; set; } // Statü sırası
    }
}
