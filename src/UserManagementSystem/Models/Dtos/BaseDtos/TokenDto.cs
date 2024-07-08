namespace UserManagementSystem.Models.Dtos.BaseDtos
{
    public class TokenDto
    {
        public string AccessToken { get; set; }

        public DateTime AccessTokenExpiration { get; set; }

        public string RefreshToken { get; set; }

        public DateTime RefreshTokenExpiration { get; set; }
        public List<string>? Roles { get; set; }
        public string email { get; set; }
    }
}
