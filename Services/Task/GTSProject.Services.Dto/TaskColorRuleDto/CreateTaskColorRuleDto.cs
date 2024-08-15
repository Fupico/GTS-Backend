using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskColorRuleDto
{
    public class CreateTaskColorRuleDto
    {
        public string? Key { get; set; }
        public string? Value { get; set; }
        public string? Color { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
