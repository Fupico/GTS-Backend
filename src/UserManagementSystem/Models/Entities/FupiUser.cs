using Microsoft.AspNetCore.Identity;

namespace UserManagementSystem.Models.Entities
{
    public class FupiUser : IdentityUser
    {

        public string? City { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
