using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskType
{
    public class CreateTaskTypeDto
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
