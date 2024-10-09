using GTSProject.Services.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.QuickAnswerDtos
{
    public class ResultQuickAnswerDto : BaseDto
    {
        public int Id { get; set; } // Güncellenecek QuickAnswer ID'si
        public string Name { get; set; }
        public string Answer { get; set; }

        // Yabancı anahtarlar (ID'ler)
        public int TaskReasonId { get; set; }
        public int UserId { get; set; } // Kullanıcı ID'si
    }
}
