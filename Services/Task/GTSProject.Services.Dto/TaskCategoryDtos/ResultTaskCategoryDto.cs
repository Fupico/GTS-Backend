using GTSProject.Services.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskCategoryDtos
{
    public class ResultTaskCategoryDto : BaseDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Group { get; set; }
        public string? GroupName { get; set; }
        public int Status { get; set; }

        // Yabancı anahtar (ID) (opsiyonel)
        public int? ParentId { get; set; } // Üst kategori (opsiyonel)
    }
}
