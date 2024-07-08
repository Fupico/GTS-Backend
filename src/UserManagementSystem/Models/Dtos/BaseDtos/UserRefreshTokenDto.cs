namespace UserManagementSystem.Models.Dtos.BaseDtos
{
    public class UserRefreshTokenDto
    {
        public string UserId { get; set; }
        public string Code { get; set; }
        public DateTime Expiration { get; set; }
    }
}
