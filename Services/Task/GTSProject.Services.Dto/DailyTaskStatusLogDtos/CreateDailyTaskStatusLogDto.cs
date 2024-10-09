using GTSProject.Services.Core.Entities;

namespace GTSProject.Services.Dto.DailyTaskStatusLogDtos
{
    public class CreateDailyTaskStatusLogDto : BaseDto
    {
        public DateTime TaskCreateDate { get; set; }
        public DateTime TaskUpdateDate { get; set; }

        // Yabancı anahtarlar (ID'ler)
        public int TaskId { get; set; }
        public int AssigneeId { get; set; } // User Id
        public int SprintId { get; set; }
        public int TaskStatusId { get; set; }

    }
}
