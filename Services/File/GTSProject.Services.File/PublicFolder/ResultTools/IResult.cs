namespace GTSProject.Services.File.PublicFolder.ResultTools
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
        string Code { get; }

    }

}
