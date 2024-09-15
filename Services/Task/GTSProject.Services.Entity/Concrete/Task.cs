using GTSProject.Services.Core.Entity;

namespace GTSProject.Services.Entity.Concrete
{
    public class Task : IEntity // Talepler
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

        public ICollection<DailyTaskStatusLog> DailyTaskStatusLogs { get; set; }
        public ICollection<TaskAttachment> TaskAttachments { get; set; }
        public ICollection<TaskComment> TaskComments { get; set; }
        public TaskRating TaskRating { get; set; }
        public ICollection<TaskRelation> TaskRelations { get; set; }
        public ICollection<TaskResponsible> TaskResponsibles { get; set; }
        public ICollection<TaskStatusLog> TaskStatusLogs { get; set; }
        public ICollection<TaskWatcher> TaskWatchers { get; set; }
        #endregion
    }
}
