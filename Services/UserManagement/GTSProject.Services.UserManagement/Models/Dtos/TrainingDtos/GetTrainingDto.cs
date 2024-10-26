using System.ComponentModel.DataAnnotations;

namespace GTSProject.Services.UserManagement.Models.Dtos.TrainingDtos
{
    public class GetTrainingDto
    {
        public string Id { get; set; }
        public string? Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Statu { get; set; }
    }
}
