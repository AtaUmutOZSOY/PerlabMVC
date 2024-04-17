namespace Core.ResponseStructure
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }

}
