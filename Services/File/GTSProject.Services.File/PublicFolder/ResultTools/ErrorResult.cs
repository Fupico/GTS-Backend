namespace GTSProject.Services.File.PublicFolder.ResultTools
{
    public class ErrorResult : Result
    {
        public ErrorResult(string message, string code) : base(false, message, code)
        {

        }
        public ErrorResult() : base(false)
        {

        }
    }

}
