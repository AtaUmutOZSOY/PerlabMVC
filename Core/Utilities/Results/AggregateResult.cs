namespace Core.Utilities.Results
{
    public class AggregateResult : IResult
    {
        public AggregateResult(IEnumerable<IResult> results)
        {
            Results = results;
            Success = false;
            Message = "";
        }

        public bool Success { get; }
        public IEnumerable<IResult> Results { get; }

        public string Message { get; }
    }
}
