using GTSProject.Services.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskSubjectTypeDtos
{
    public class CreateTaskSubjectTypeDto : BaseDto
    {
        public string Name { get; set; } // Konu türünün adı
    }
}
