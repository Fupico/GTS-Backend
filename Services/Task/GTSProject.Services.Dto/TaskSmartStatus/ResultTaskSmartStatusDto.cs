using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskSmartStatus
{
    public class ResultTaskSmartStatusDto
    {
        public int Id { get; set; }
        public int StatusId { get; set; }
        public int AvailableStatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
