using Core.DataAccess.Concrete;
using Core.Entity.Concretes;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfUserDal : EfEntityRepositoryBase<User, PerlabDbContext>, IUserDal
    {
        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            using (var context = new PerlabDbContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return new SuccessDataResult<List<OperationClaim>>(result.ToList());

            }
        }
    }
}
