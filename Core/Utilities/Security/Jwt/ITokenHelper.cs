using Core.Entity.Concretes;
using System.Security.Claims;

namespace Core.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
        ClaimsPrincipal ValidateToken(string token);
        RefreshToken CreateRefreshToken(User user);


    }
}
