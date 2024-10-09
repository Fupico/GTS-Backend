using GTSProject.Services.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskCommentDtos
{
    public class ResultTaskCommentDto : BaseDto
    {
        public int Id { get; set; }
        public string? Message { get; set; }
        public bool HasAttachment { get; set; }
        public bool ShowToAllUser { get; set; }

        // Yabancı anahtarlar (ID'ler)
        public int TaskId { get; set; }
        public int UserId { get; set; } // User Id
        public int QuickAnswerId { get; set; }
    }
}
