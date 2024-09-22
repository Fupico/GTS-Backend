using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskStatusLog
{
    public class CreateTaskStatusLogDto
    {
        public int TaskId { get; set; }
        public int StatusId { get; set; }
        public int AssigneeId { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
