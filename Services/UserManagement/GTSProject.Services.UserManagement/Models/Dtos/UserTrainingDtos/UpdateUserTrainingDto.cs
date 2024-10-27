namespace GTSProject.Services.UserManagement.Models.Dtos.UserTrainingDtos
{
    public class UpdateUserTrainingDto
    {
        public int TrainingId { get; set; }
        public bool Attended { get; set; } // Kullanıcının eğitime katılıp katılmadığını günceller

    }
}
