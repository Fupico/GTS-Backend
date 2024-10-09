using GTSProject.Services.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.SprintDtos
{
    public class GetByIdSprintDto : BaseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StartDateWeekNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Yabancı anahtarlar (ID'ler)
        public int TaskProjectId { get; set; }
        public int TribeId { get; set; }
        public int SprintStatusId { get; set; }
    }
}
