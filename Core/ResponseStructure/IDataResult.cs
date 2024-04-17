namespace Core.ResponseStructure
{
    public interface IDataResult<out T> : IResult
    {
        T Data { get; }
    }

}
