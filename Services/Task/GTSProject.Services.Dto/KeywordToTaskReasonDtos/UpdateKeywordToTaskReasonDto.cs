using GTSProject.Services.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.KeywordToTaskReasonDtos
{
    public class UpdateQuickAnswerDto : BaseDto
    {
        public int Id { get; set; }
        // Anahtar kelime
        public string Keyword { get; set; }

        // Yabancı anahtarlar (ID'ler)
        public int TaskCategoryId { get; set; }
        public int TaskReasonId { get; set; }
    }
}
