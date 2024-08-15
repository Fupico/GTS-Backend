using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.RejectedTaskDtos
{
    public class GetByIdRejectedTaskDto
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int UserId { get; set; }
    }
}
