using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskDeadLineLogDtos
{
    public class GetByIdTaskDeadLineLogDto
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public DateTime DeadLine { get; set; }
        public string? Description { get; set; }
        public int UserId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
