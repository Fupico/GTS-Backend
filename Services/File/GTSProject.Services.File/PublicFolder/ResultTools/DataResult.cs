namespace GTSProject.Services.File.PublicFolder.ResultTools
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool success, string message, string code) : base(success, message, code)
        {

            Data = data;
            Code = code;
            Message = message;

        }
        public DataResult(T data, bool success) : base(success)
        {

            Data = data;

        }

        public T Data { get; }
        public string Code { get; }
        public string Message { get; }
    }

}
