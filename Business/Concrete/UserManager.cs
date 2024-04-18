
using Business.Abstract;
using Business.Constants.Messages;
using Core.Entity.Concretes;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

      

        public IResult Add(User user)
        {
            bool isUserExist = IsUserExist(user);
            if (isUserExist)
            {
                _userDal.Add(user);
                return new SuccessResult(Messages.SucceedAdd);
            }
            return new ErrorResult(Messages.UserAlreadyExists);
        }

        public IDataResult<User> GetByMail(string mail)
        {
            var result = _userDal.Get(x=>x.Email == mail);
            if (result is not null)
            {
                return new SuccessDataResult<User>(result);
            }
            return new ErrorDataResult<User>(Messages.UserNotFound);
        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        private bool IsUserExist(User user)
        {
            var result = _userDal.Get(x=>x.Email ==  user.Email);
            if (result is not null )
            {
                return false;
            }
            return true;
        }
    }
}
