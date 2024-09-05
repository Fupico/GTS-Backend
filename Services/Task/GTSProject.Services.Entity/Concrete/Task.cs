﻿namespace GTSProject.Services.Entity.Concrete
{
    public class Task // Talepler
    {
        public Guid Id { get; set; }
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

        #region İlişkiler
        public Guid ParentId { get; set; } // Herhangi bir ilişki gerekmiyor. Üst task.

        public int TaskProjectId { get; set; }
        public TaskProject TaskProject { get; set; }

        public int TaskTypeId { get; set; }
        public TaskType TaskType { get; set; }

        public Guid ReporterId { get; set; } // Userdan atayan kişi idsi gelecek
        public Guid AssigneeId { get; set; } // Userdan atanan kişi idsi gelecek

        public int CategoryId { get; set; }
        public TaskCategory TaskCategory { get; set; }

        public int StatusId { get; set; }
        public TaskStatus TaskStatus { get; set; }

        public int TaskReasonId { get; set; }
        public TaskReason TaskReason { get; set; }

        public int TaskSubjectTypeId { get; set; }
        public TaskSubjectType TaskSubjectType { get; set; }

        public Guid CloserId { get; set; }  // Userdan kapayan kişi idsi gelecek
        public int CloserDepartmentId { get; set; } // Kapayan departman id

        public ICollection<DailyTaskStatusLog> DailyTaskStatuses { get; set; }
        public ICollection<TaskAttachment> TaskAttachments { get; set; }
        public ICollection<TaskComment> TaskComments { get; set; }
        public TaskRating TaskRating { get; set; }
        public ICollection<TaskRelation> TaskRelations { get; set; }
        #endregion
    }
}
