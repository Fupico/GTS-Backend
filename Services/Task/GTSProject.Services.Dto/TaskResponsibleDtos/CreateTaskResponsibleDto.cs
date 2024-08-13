using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskResponsibleDtos
{
    public class CreateTaskResponsibleDto
    {
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public int CreatorUserId { get; set; }
    }
}
