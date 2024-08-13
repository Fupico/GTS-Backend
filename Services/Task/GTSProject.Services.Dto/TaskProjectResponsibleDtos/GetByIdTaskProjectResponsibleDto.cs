using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskProjectResponsibleDtos
{
    public class GetByIdTaskProjectResponsibleDto
    {
        public int Id { get; set; }
        public int PropjectId { get; set; }
        public int CreatorId { get; set; }
        public int UserId { get; set; }
    }
}
