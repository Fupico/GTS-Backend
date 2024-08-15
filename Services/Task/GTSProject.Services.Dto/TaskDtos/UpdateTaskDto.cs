using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.Dto.TaskDtos
{
    public class UpdateTaskDto
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int TaskProjectId { get; set; }
        public int TaskTypeId { get; set; }
        public int TaskSourceId { get; set; }
        public int ReporterId { get; set; }
        public int AssigneeId { get; set; }
        public int ProductId { get; set; }
        public string? Subject { get; set; }
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        public int StatusId { get; set; }
        public DateTime DeadLine { get; set; }
        public int TaskReasonId { get; set; }
        public int WorkLoad { get; set; }
        public int HasAttachment { get; set; }
        public int TaskSubjectTypeId { get; set; }
        public int CustomerNotificationTypeId { get; set; }
        public int ProblemSourceId { get; set; }
        public int CloserId { get; set; }
        public int CloserDepartmentId { get; set; }
        public int ReporterIsRight { get; set; }
        public int ReplyEmail { get; set; }
        public int ReplyPhone { get; set; }
        public int EffortDevelopment { get; set; }
        public int EffortAnalyse { get; set; }
        public int EffortTechnic { get; set; }
        public int PendingOn { get; set; }
        public int PriorityOrder { get; set; }
        public string? Color { get; set; }
        public int SprintId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
