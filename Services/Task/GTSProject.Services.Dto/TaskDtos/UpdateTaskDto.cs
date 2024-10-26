using GTSProject.Services.Core.Entities;

namespace GTSProject.Services.Dto.TaskDtos
{
    public class UpdateTaskDto : BaseDto
    {
        public int Id { get; set; }
        public string? Subject { get; set; }
        public string? Description { get; set; }
        public DateTime DeadLine { get; set; }
        public int WorkLoad { get; set; }
        public int HasAttachment { get; set; }
        public int ReporterIsRight { get; set; }
        public int ReplyEmail { get; set; }
        public int ReplyPhone { get; set; }
        public int EffortDevelopment { get; set; }
        public int EffortAnalyse { get; set; }
        public int EffortTechnic { get; set; }
        public int PendingOn { get; set; }
        public int PriorityOrder { get; set; }
        public string? Color { get; set; }

        // Yabancı anahtarlar (ID'ler)
        public int? ParentId { get; set; } // Üst task opsiyonel
        public int TaskProjectId { get; set; }
        public int TaskTypeId { get; set; }
        public int ReporterId { get; set; } // User Id
        public int AssigneeId { get; set; } // User Id

        public int TaskCategoryId { get; set; }
        public int TaskStatusId { get; set; }
        public int TaskReasonId { get; set; }
        public int TaskSubjectTypeId { get; set; }

        public int CloserId { get; set; } // User Id
        public int CloserDepartmentId { get; set; } // Departman Id

    }
}
