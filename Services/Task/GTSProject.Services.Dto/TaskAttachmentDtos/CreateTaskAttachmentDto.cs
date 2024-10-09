using GTSProject.Services.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskAttachmentDtos
{
    public class CreateTaskAttachmentDto : BaseDto
    {
        public string? FolderName { get; set; }
        public string? FileName { get; set; }
        public bool ShowToAllUser { get; set; }

        // Yabancı anahtarlar (ID'ler)
        public int TaskId { get; set; }
        public int TaskCommentId { get; set; }
        public int UserId { get; set; } // User Id
    }
}
