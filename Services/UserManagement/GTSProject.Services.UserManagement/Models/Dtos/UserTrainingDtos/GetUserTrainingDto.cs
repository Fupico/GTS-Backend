namespace GTSProject.Services.UserManagement.Models.Dtos.UserTrainingDtos
{
    public class GetUserTrainingDto
    {
        public int Id { get; set; } // UserTraining'ın ID'si
        public int TrainingId { get; set; } // Kullanıcının katıldığı eğitimin ID'si
        public string TrainingName { get; set; } // Eğitimin adı
        public string TrainingDescription { get; set; } // Eğitimin açıklaması
        public DateTime TrainingStartDate { get; set; } // Eğitimin başlangıç tarihi
        public DateTime TrainingEndDate { get; set; } // Eğitimin bitiş tarihi
        public bool TrainingStatu { get; set; } // Eğitimin statüsü
        public bool Attended { get; set; } // Kullanıcının eğitime katılıp katılmadığını belirtir
    }
}
