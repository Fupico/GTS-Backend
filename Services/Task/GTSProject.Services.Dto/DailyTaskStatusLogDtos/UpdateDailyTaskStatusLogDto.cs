using GTSProject.Services.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.DailyTaskStatusLogDtos
{
    public class UpdateDailyTaskStatusLogDto : BaseDto
    {
        public int Id { get; set; }

        public DateTime TaskCreateDate { get; set; }
        public DateTime TaskUpdateDate { get; set; }

        // Yabancı anahtarlar (ID'ler)
        public int TaskId { get; set; }
        public int AssigneeId { get; set; } // User Id
        public int SprintId { get; set; }
        public int TaskStatusId { get; set; }
    }
}
