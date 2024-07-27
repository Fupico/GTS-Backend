namespace UserManagementSystem.Models.Dtos.BaseDtos
{
    public class ErrorDto
    {
        public List<String> Errors { get; private set; } = [];

        public bool IsShow { get; private set; }

        public ErrorDto(string error, bool isShow)
        {
            Errors.Add(error);
            IsShow = isShow;
        }

        public ErrorDto(List<string> errors, bool isShow)
        {
            Errors = errors;
            IsShow = isShow;
        }

       
      
    }
}
