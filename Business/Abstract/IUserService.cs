
using Core.Entity.Concretes;
using Core.Utilities.Results;
using Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);

        IDataResult<User> GetByMail(string mail);

        IDataResult<List<OperationClaim>> GetClaims(User user);

    }
}
