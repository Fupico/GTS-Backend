using System.ComponentModel.DataAnnotations;
using UserManagementSystem.Models.Entities;

namespace GTSProject.Services.UserManagement.Models.Entities
{
    public class UserTraining
    {
        [Key]
        public string Id { get; set; }
        public string UserId { get; set; }
        public FupiUser User { get; set; }

        public string TrainingId { get; set; }
        public Training Training { get; set; }

        public bool Attended { get; set; } // Kullanıcının eğitime katılıp katılmadığını belirtir
    }
}
