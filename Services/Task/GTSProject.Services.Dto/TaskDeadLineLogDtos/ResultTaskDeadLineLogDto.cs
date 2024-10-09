using GTSProject.Services.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskDeadLineLogDtos
{
    public class ResultTaskDeadLineLogDto : BaseDto
    {
        public int Id { get; set; }
        public DateTime DeadLine { get; set; }
        public string? Description { get; set; }

        // Yabancı anahtarlar (ID'ler)
        public int TaskId { get; set; }
        public int UserId { get; set; } // User Id
    }
}
