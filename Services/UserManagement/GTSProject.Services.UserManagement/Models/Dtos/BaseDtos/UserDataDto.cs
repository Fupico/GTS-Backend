namespace UserManagementSystem.Models.Dtos.BaseDtos
{
    public class UserDataDto
    {
        public string UserId { get; private set; }
        public string UserIP { get; private set; }
        public List<string> Roles { get; private set; }
        public List<string> AuthWorkplaces { get; private set; }
        public List<string> PermissionList { get; private set; }

        public void SetUserContext(string userId, string userIP, List<string> roles)
        {
            UserId = userId;
            UserIP = userIP;
            Roles = roles;

        }
    }
}
