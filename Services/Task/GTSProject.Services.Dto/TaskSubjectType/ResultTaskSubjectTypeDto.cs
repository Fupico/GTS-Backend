using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskSubjectType
{
    public class ResultTaskSubjectTypeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SlaGroup { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
