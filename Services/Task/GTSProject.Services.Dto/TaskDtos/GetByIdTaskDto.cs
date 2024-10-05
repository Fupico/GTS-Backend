using GTSProject.Services.Dto.DailyTaskStatusLogDtos;
using GTSProject.Services.Dto.TaskAttachmentDtos;
using GTSProject.Services.Dto.TaskCommentDtos;
using GTSProject.Services.Dto.TaskEffortDtos;
using GTSProject.Services.Dto.TaskHistoryDtos;
using GTSProject.Services.Dto.TaskRatingDtos;
using GTSProject.Services.Dto.TaskRelation;
using GTSProject.Services.Dto.TaskResponsibleDtos;
using GTSProject.Services.Dto.TaskStatusLog;
using GTSProject.Services.Dto.TaskWatcher;

namespace GTSProject.Services.Dto.TaskDtos
{
    public class GetByIdTaskDto
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

        public int? ParentId { get; set; }
        public string? ParentTaskSubject { get; set; }

        public string TaskProjectName { get; set; }
        public string TaskTypeName { get; set; }
        public string ReporterName { get; set; }
        public string AssigneeName { get; set; }
        public string TaskCategoryName { get; set; }
        public string TaskStatusName { get; set; }
        public string TaskReasonName { get; set; }
        public string TaskSubjectTypeName { get; set; }
        public string CloserName { get; set; }
        public string CloserDepartmentName { get; set; }

        public ICollection<ResultDailyTaskStatusLogDto>? DailyTaskStatusLogs { get; set; }
        public ICollection<ResultTaskAttachmentDto>? TaskAttachments { get; set; }
        public ICollection<ResultTaskCommentDto>? TaskComments { get; set; }
        public ICollection<ResultTaskEffortDto>? TaskEfforts { get; set; }
        public ICollection<ResultTaskHistoryDto>? TaskHistories { get; set; }
        public ICollection<ResultTaskRatingDto>? TaskRatings { get; set; }
        public ICollection<ResultTaskRelationDto>? TaskRelations { get; set; }
        public ICollection<ResultTaskResponsibleDto>? TaskResponsibles { get; set; }
        public ICollection<ResultTaskStatusLogDto>? TaskStatusLogs { get; set; }
        public ICollection<ResultTaskWatcherDto>? TaskWatchers { get; set; }
    }
}
