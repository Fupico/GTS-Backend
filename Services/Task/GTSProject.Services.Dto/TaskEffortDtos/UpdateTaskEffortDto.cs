using GTSProject.Services.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskEffortDtos
{
    public class UpdateTaskEffortDto : BaseDto
    {
        public int Id { get; set; }
        public int Effort { get; set; }
        public string Description { get; set; }
        public int ConfirmedEffort { get; set; }
        public string ConfirmedMessage { get; set; }

        // Yabancı anahtarlar (ID'ler)
        public int TaskId { get; set; }
        public int UserId { get; set; } // User Id
        public int ConfirmedByUserId { get; set; } // User Id
        public int TaskEffortTypeId { get; set; }
    }
}
