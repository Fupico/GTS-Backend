using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.DailyTaskStatusLogDtos
{
    public class ResultDailyTaskStatusLogDto
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int TaskStatusId { get; set; }
        public int AssigneeId { get; set; }
        public DateTime TaskCreateDate { get; set; }
        public DateTime TaskUpdateDate { get; set; }
        public int SprintId { get; set; }
    }
}
