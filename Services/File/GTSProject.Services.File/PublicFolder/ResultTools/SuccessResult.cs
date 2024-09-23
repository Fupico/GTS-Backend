namespace GTSProject.Services.File.PublicFolder.ResultTools
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message, string code) : base(true, message, code)
        {

        }
        public SuccessResult() : base(true)
        {

        }
    }

}
