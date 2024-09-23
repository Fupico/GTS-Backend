namespace GTSProject.Services.File.PublicFolder.ResultTools
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message, string code) : base(data, false, message, code)
        {

        }
        public ErrorDataResult(T data) : base(data, false)
        {

        }
        public ErrorDataResult(string message, string code) : base(default, false, message, code)
        {

        }
        public ErrorDataResult() : base(default, false)
        {

        }
    }

}
