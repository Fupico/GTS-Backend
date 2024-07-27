namespace UserManagementSystem.Models.Dtos.BaseDtos
{
    public class ClientDto
    {
       
            public string Id { get; set; }

            public string Secret { get; set; }

            public List<String> Audiences { get; set; }
        
    }
}
