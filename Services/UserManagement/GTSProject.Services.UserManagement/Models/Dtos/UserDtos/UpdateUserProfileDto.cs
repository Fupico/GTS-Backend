namespace GTSProject.Services.UserManagement.Models.Dtos.UserDtos
{
    public class UpdateUserProfileDto 
    {
      //  public string UserId { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? City { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
