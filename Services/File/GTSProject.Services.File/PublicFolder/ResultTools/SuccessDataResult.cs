namespace GTSProject.Services.File.PublicFolder.ResultTools
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, string message, string code) : base(data, true, message, code)
        {

        }
        public SuccessDataResult(T data) : base(data, true)
        {

        }
        public SuccessDataResult(string message, string code) : base(default, true, message, code)
        {

        }
        public SuccessDataResult() : base(default, true)
        {

        }
    }

}
