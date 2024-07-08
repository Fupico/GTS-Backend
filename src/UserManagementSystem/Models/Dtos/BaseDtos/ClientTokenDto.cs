namespace UserManagementSystem.Models.Dtos.BaseDtos
{
    public class ClientTokenDto
    {
        public string AccessToken { get; set; }

        public DateTime AccessTokenExpiration { get; set; }
    }
}
