using System.ComponentModel.DataAnnotations;

namespace GTSProject.Services.UserManagement.Models.Entities
{
    public class Training
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; } // Eğitimin süresi (saat veya gün cinsinden)
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Location { get; set; } // Eğitimin yapılacağı yer bilgisi
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime? UpdatedDate { get; set; }
        public bool Statu { get; set; }
        // Kullanıcılarla ilişki
        public ICollection<UserTraining> UserTrainings { get; set; } // Kullanıcı eğitim ilişkisi
    }
}
