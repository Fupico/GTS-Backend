namespace GTSProject.Services.UserManagement.Models.Dtos.TrainingDtos
{
    public class UpdateTrainingDto
    {
        public string Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? Duration { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Location { get; set; }
        public bool? Statu { get; set; }
    }
}
