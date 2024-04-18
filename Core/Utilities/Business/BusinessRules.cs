using Core.Utilities.Results;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)
        {
            List<IResult> failedResults = new List<IResult>();

            foreach (var result in logics)
            {
                if (!result.Success)
                {
                    failedResults.Add(result);
                }
            }

            if (failedResults.Any())
            {
                foreach (var failedResult in failedResults)
                {
                    return new ErrorResult(failedResult.Message);
                }
            }

            return new SuccessResult();
        }
    }
}
