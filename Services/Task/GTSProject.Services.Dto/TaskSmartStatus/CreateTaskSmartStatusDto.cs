using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskSmartStatus
{
    public class CreateTaskSmartStatusDto
    {
        public int StatusId { get; set; }
        public int AvailableStatusId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
