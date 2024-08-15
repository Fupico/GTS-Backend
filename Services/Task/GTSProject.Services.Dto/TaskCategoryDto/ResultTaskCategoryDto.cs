using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskCategoryDto
{
    public class ResultTaskCategoryDto
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string? Name { get; set; }
        public int Group { get; set; }
        public string? GroupName { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
