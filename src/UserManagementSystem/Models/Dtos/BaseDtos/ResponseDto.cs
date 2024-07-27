namespace UserManagementSystem.Models.Dtos.BaseDtos
{

    public class ResponseDto<T> where T : class
    {

        public T? Data { get; set; }

        public int status { get; set; }

        public bool IsSuccessful { get; set; } // kendi iç yapımızda kullanacağız.
        public ErrorDto? errors { get; set; }
   
        public static ResponseDto<T> Success(T data, int status)
        {
            return new ResponseDto<T> { Data = data, status = status, IsSuccessful = true };
        }
        public static ResponseDto<T> Success(int status)
        {
            return new ResponseDto<T> { Data = default, status = status, IsSuccessful = true };
        }
        public static ResponseDto<T> Fail(ErrorDto errorDto, int status)
        {
            return new ResponseDto<T> { errors = errorDto, status = status, IsSuccessful = false };
        }
      
        public static ResponseDto<T> Fail(string errorMessage, int status, bool isShow)
        {
            var errorDto = new ErrorDto(errorMessage, isShow);
            return new ResponseDto<T> { errors = errorDto, status = status, IsSuccessful = false };

        }
    }

}
