namespace GTSProject.Services.Core.Results
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}
