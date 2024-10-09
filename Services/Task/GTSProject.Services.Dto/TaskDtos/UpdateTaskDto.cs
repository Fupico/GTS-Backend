using GTSProject.Services.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

<<<<<<< HEAD
        // Yabancı anahtarlar (ID'ler)
        public int? ParentId { get; set; } // Üst task opsiyonel
        public int TaskProjectId { get; set; }
        public int TaskTypeId { get; set; }
        public int ReporterId { get; set; } // User Id
        public int AssigneeId { get; set; } // User Id
=======
        public int? ParentId { get; set; }
        public int TaskProjectId { get; set; }
        public int TaskTypeId { get; set; }
        public int ReporterId { get; set; }
        public int AssigneeId { get; set; }
>>>>>>> 7aa54aab5141a4d312cc629ad838aa6dce26d42c
        public int TaskCategoryId { get; set; }
        public int TaskStatusId { get; set; }
        public int TaskReasonId { get; set; }
        public int TaskSubjectTypeId { get; set; }
<<<<<<< HEAD
        public int CloserId { get; set; } // User Id
        public int CloserDepartmentId { get; set; } // Departman Id
=======
        public int CloserId { get; set; }
        public int CloserDepartmentId { get; set; }
>>>>>>> 7aa54aab5141a4d312cc629ad838aa6dce26d42c
    }
}
