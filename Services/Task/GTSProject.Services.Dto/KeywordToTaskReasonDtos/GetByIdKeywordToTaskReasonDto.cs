using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.KeywordToTaskReasonDtos
{
    public class GetByIdKeywordToTaskReasonDto
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int ProductId { get; set; }
        public string? Keyword { get; set; }
        public int ReasonId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
