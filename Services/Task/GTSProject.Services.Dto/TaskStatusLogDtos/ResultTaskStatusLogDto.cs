using GTSProject.Services.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskStatusLogDtos
{
    public class ResultTaskStatusLogDto : BaseDto
    {
        public int Id { get; set; }
        public string Description { get; set; } // Durum açıklaması

        // İlişkiler
        public int TaskId { get; set; } // İlgili görev ID'si
        public int TaskStatusId { get; set; } // İlgili durum ID'si
        public int AssigneeId { get; set; } // Atanan kullanıcının ID'si
        public int UserId { get; set; } // Kullanıcının ID'si
    }
}
