namespace GTSProject.Services.Dto.DailyTaskStatusLogDtos
{
    public class CreateDailyTaskStatusLogDto
    {
        public int TaskId { get; set; }
        public int TaskStatusId { get; set; }
        public int AssigneeId { get; set; }
        public DateTime TaskCreateDate { get; set; }
        public DateTime TaskUpdateDate { get; set; }
        public int SprintId { get; set; }
    }
}
