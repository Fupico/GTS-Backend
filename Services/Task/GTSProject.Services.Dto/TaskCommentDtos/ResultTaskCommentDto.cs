using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskCommentDtos
{
    public class ResultTaskCommentDto
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public int QuickAnswerId { get; set; }
        public string? Message { get; set; }
        public int HasAttachment { get; set; }
        public bool AgencyCanView { get; set; }
        public bool ShowOnlyToDepartment { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
