namespace GTSProject.Services.File.PublicFolder.ResultTools
{
    public class Result : IResult
    {
        //this(success) koyarak ilk ctor çalışırken kapsadığı diğer ctor da çalışıyor

        public Result(bool success, string message, string code) : this(success)
        {
            Message = message;
            Code = code;

        }
        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }

        public string Message { get; }
        public string Code { get; }
    }

}
