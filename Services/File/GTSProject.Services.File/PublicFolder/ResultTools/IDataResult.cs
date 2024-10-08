namespace GTSProject.Services.File.PublicFolder.ResultTools
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }

}
