using GTSProject.Services.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskSubjectTypeDtos
{
    public class ResultTaskSubjectTypeDto : BaseDto
    {
        public int Id { get; set; }
        public string Name { get; set; } // Konu türünün adı
    }
}
