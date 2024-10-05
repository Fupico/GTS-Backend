using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskDtos
{
    public class ResultTaskDto
    {
        public int Id { get; set; }
        public string? Subject { get; set; }
        public string? Description { get; set; }
        public DateTime DeadLine { get; set; }
        public int WorkLoad { get; set; }
        public int PriorityOrder { get; set; }
        public string? Color { get; set; }

        public string TaskProjectName { get; set; }
        public string TaskTypeName { get; set; }
        public string AssigneeName { get; set; }
        public string TaskStatusName { get; set; }
        public string TaskCategoryName { get; set; }
    }
}
