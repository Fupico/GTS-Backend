using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.DailyTaskStatusLogDtos
{
    public class UpdateDailyTaskStatusLogDto
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int StatusId { get; set; }
        public int AssigneeId { get; set; }
        public DateTime TaskCreateDate { get; set; }
        public DateTime TaskUpdateDate { get; set; }
        public int SprintId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
