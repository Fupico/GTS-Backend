using GTSProject.Services.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskHistoryDtos
{
    public class CreateTaskHistoryDto : BaseDto
    {
        // Talep geçmişi için gerekli alanlar
        public string Message { get; set; }
        public int TaskId { get; set; } // İlgili görev kimliği
        public int UserId { get; set; } // İlgili kullanıcı kimliği
        public int TaskStatusId { get; set; } // İlgili görev durumu kimliği
    }
}
