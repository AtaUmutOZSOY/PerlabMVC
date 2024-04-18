using Core.Entity.Concretes;
using Core.Utilities.Results;
using Core.Utilities.Security.Jwt;
using Models.Concrete;
using Models.Dtos.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto,string password);
        IDataResult<AccessToken> CreateAccessToken(User user);

        IResult CheckUserAuthentication(AccessToken accessToken);
        IResult UserExists(string email);

    }
}
