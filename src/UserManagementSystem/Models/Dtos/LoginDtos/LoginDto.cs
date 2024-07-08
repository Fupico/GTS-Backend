namespace UserManagementSystem.Models.Dtos.LoginDtos
{
    public class LoginDto
    {

        public string Email { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; } = true;

    }
}
