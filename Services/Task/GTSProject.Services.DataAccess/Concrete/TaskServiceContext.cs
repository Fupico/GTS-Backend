using GTSProject.Services.Core.Entities;
using GTSProject.Services.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace GTSProject.Services.DataAccess.Concrete
{
    public class TaskServiceContext : DbContext
    {
        public TaskServiceContext(DbContextOptions<TaskServiceContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        public TaskServiceContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sprint>()
                .HasOne(s => s.Tribe)
                .WithMany(t => t.Sprints)
                .HasForeignKey(s => s.TribeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TaskComment>()
                .HasOne(tc => tc.Task)
                .WithMany(t => t.TaskComments)
                .HasForeignKey(tc => tc.TaskId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TaskEffort>()
                .HasOne(te => te.Task)
                .WithMany(t => t.TaskEfforts)
                .HasForeignKey(te => te.TaskId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TaskHistory>()
                .HasOne(th => th.Task)
                .WithMany(t => t.TaskHistories)
                .HasForeignKey(th => th.TaskId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TaskRating>()
                .HasOne(tr => tr.Task)
                .WithMany(t => t.TaskRatings)
                .HasForeignKey(tr => tr.TaskId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TaskStatusLog>()
                .HasOne(tsl => tsl.Task)
                .WithMany(t => t.TaskStatusLogs)
                .HasForeignKey(tsl => tsl.TaskId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DailyTaskStatusLog>()
                .HasOne(dtsl => dtsl.Task)
                .WithMany(t => t.DailyTaskStatusLogs)
                .HasForeignKey(dtsl => dtsl.TaskId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TaskAttachment>()
                .HasOne(ta => ta.Task)
                .WithMany(t => t.TaskAttachments)
                .HasForeignKey(ta => ta.TaskId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        public DbSet<DailyTaskStatusLog> DailyTaskStatusLogs { get; set; }
        public DbSet<KeywordToTaskReason> KeywordToTaskReasons { get; set; }
        public DbSet<QuickAnswer> QuickAnswers { get; set; }
        public DbSet<Sprint> Sprints { get; set; }
        public DbSet<SprintStatus> SprintStatuses { get; set; }
        public DbSet<Entity.Concrete.Task> Tasks { get; set; }
        public DbSet<TaskAttachment> TaskAttachments { get; set; }
        public DbSet<TaskAutoAssignRule> TaskAutoAssignRules { get; set; }
        public DbSet<TaskCategory> TaskCategories { get; set; }
        public DbSet<TaskColorRule> TaskColorRules { get; set; }
        public DbSet<TaskComment> TaskComments { get; set; }
        public DbSet<TaskDeadLineLog> TaskDeadLineLogs { get; set; }
        public DbSet<TaskEffort> TaskEfforts { get; set; }
        public DbSet<TaskEffortType> TaskEffortTypes { get; set; }
        public DbSet<TaskHistory> TaskHistories { get; set; }
        public DbSet<TaskProject> TaskProjects { get; set; }
        public DbSet<TaskRating> TaskRatings { get; set; }
        public DbSet<TaskReason> TaskReasons { get; set; }
        public DbSet<TaskRelation> TaskRelations { get; set; }
        public DbSet<TaskRelationType> TaskRelationTypes { get; set; }
        public DbSet<TaskResponsible> TaskResponsibles { get; set; }
        public DbSet<Entity.Concrete.TaskStatus> TaskStatuses { get; set; }
        public DbSet<TaskStatusLog> TaskStatusLogs { get; set; }
        public DbSet<TaskSubjectType> TaskSubjectTypes { get; set; }
        public DbSet<TaskType> TaskTypes { get; set; }
        public DbSet<TaskWatcher> TaskWatchers { get; set; }
        public DbSet<Tribe> Tribes { get; set; }
        public DbSet<TribeMember> TribeMembers { get; set; }
        public DbSet<TribeMemberRole> TribeMemberRoles { get; set; }
        //public DbSet<User> Users { get; set; }
    }
}