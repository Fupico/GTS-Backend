using GTSProject.Services.Core.Entities;

namespace GTSProject.Services.Entity.Concrete
{
    public class Task : BaseEntity // Talepler
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

        #region İlişkiler
        public int? ParentId { get; set; } // Üst task opsiyonel olarak yapılabilir
        public virtual Task? ParentTask { get; set; }

        public int TaskProjectId { get; set; }
        public virtual TaskProject TaskProject { get; set; }

        public int TaskTypeId { get; set; }
        public virtual TaskType TaskType { get; set; }

        public int ReporterId { get; set; } // User Id
        public int AssigneeId { get; set; } // User Id

        public int TaskCategoryId { get; set; }
        public virtual TaskCategory TaskCategory { get; set; }

        public int TaskStatusId { get; set; }
        public virtual TaskStatus TaskStatus { get; set; }

        public int TaskReasonId { get; set; }
        public virtual TaskReason TaskReason { get; set; }

        public int TaskSubjectTypeId { get; set; }
        public virtual TaskSubjectType TaskSubjectType { get; set; }

        public int CloserId { get; set; }  // User Id
        public int CloserDepartmentId { get; set; } // Departman Id

        public ICollection<DailyTaskStatusLog> DailyTaskStatusLogs { get; set; }
        public ICollection<TaskAttachment> TaskAttachments { get; set; }
        public ICollection<TaskComment> TaskComments { get; set; }
        public ICollection<TaskEffort> TaskEfforts { get; set; }
        public ICollection<TaskHistory> TaskHistories { get; set; }
        public ICollection<TaskRating> TaskRatings { get; set; }
        public ICollection<TaskRelation> TaskRelations { get; set; }
        public ICollection<TaskResponsible> TaskResponsibles { get; set; }
        public ICollection<TaskStatusLog> TaskStatusLogs { get; set; }
        public ICollection<TaskWatcher> TaskWatchers { get; set; }
        #endregion
    }
}