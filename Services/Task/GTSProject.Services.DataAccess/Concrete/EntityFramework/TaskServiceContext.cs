using GTSProject.Services.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace GTSProject.Services.DataAccess.Concrete.EntityFramework
{
    public class TaskServiceContext : DbContext
    {
        public TaskServiceContext(DbContextOptions<TaskServiceContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        public TaskServiceContext()
        {

        }


        public DbSet<DailyTaskStatusLog> DailyTaskStatusLogs { get; set; }
        //public DbSet<KeywordToTaskReason> KeywordToTaskReasons { get; set; }
        //public DbSet<RejectedTask> RejectedTasks { get; set; }
        //public DbSet<Entity.Concrete.Task> Tasks { get; set; }
        //public DbSet<TaskAttachment> TaskAttachments { get; set; }
        //public DbSet<TaskAutoAssignRule> TaskAutoAssignRules { get; set; }
        //public DbSet<TaskCategory> TaskCategories { get; set; }
        //public DbSet<TaskColorRule> TaskColorRules { get; set; }
        //public DbSet<TaskComment> TaskComments { get; set; }
        //public DbSet<TaskDeadLineLog> TaskDeadLineLogs { get; set; }
        //public DbSet<TaskEffort> TaskEfforts { get; set; }
        //public DbSet<TaskEffortType> TaskEffortTypes { get; set; }
        //public DbSet<TaskHistory> TaskHistories { get; set; }
        //public DbSet<TaskProduct> TaskProducts { get; set; }
        //public DbSet<TaskProject> TaskProjects { get; set; }
        //public DbSet<TaskProjectResponsible> TaskProjectResponsibles { get; set; }
        //public DbSet<TaskRating> TaskRatings { get; set; }
        //public DbSet<TaskReason> TaskReasons { get; set; }
        //public DbSet<TaskRelation> TaskRelations { get; set; }
        //public DbSet<TaskRelationType> TaskRelationTypes { get; set; }
        //public DbSet<TaskResponsible> TaskResponsibles { get; set; }
        //public DbSet<TaskSlaLog> TaskSlaLogs { get; set; }
        //public DbSet<TaskSmartStatus> TaskSmartStatuses { get; set; }
        //public DbSet<TaskSource> TaskSources { get; set; }
        //public DbSet<Entity.Concrete.TaskStatus> TaskStatuses { get; set; }
        //public DbSet<TaskStatusLog> TaskStatusLogs { get; set; }
        //public DbSet<TaskSubjectType> TaskSubjectTypes { get; set; }
        //public DbSet<TaskTag> TaskTags { get; set; }
        //public DbSet<TaskType> TaskTypes { get; set; }
        //public DbSet<TaskWatcher> TaskWatchers { get; set; }
        //public DbSet<User> Users { get; set; }
    }
}
