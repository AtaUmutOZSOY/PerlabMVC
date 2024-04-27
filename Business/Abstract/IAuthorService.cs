using Core.Utilities.Results;
using DataAccess.Abstract;
using Models.Concrete;
using Models.Dtos.Authors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAuthorService
    {
        IResult CreateNewAuthor(CreateAuthorRequestDto createAuthorRequestDto);
        IResult DeleteAuthorById(int id);

        IDataResult<List<Author>> GetAll();

        IDataResult<Author> GetById(int id);
    }
}
