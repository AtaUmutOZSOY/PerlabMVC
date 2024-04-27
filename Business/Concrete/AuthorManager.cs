using Business.Abstract;
using Business.Constants.Messages;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Models.Concrete;
using Models.Dtos.Authors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthorManager : IAuthorService
    {
        IAuthorDal _authorDal;

        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }

        public IResult CreateNewAuthor(CreateAuthorRequestDto createAuthorRequestDto)
        {
            var result = BusinessRules.Run(CheckExistAuthor(createAuthorRequestDto));
            if (result.Success)
            {
                var author = new Author()
                {
                    Affiliation = createAuthorRequestDto.Affiliation,
                    FirstName = createAuthorRequestDto.FirstName,
                    LastName = createAuthorRequestDto.LastName,
                    MiddleName = createAuthorRequestDto.MiddleName,
                };
                _authorDal.Add(author);
                return new SuccessResult(Messages.SucceedAdd);
            }
            return new ErrorResult(result.Message);
        }

        private IResult CheckExistAuthor(CreateAuthorRequestDto author)
        {
            var result = _authorDal.Get(x=>x.FirstName == author.FirstName&&x.LastName==author.LastName&&x.MiddleName == author.MiddleName);
            if (result is null)
            {
                return new SuccessResult();
            }
            return new ErrorResult("Author already exist");
        }

        public IResult DeleteAuthorById(int id)
        {
            var existAuthor = _authorDal.Get(x => x.Id == id);
            if (existAuthor is not null)
            {
                _authorDal.Delete(existAuthor);
                return new SuccessResult(Messages.SucceedDelete);
            }
            return new ErrorResult("Author not found");
        }

        public IDataResult<List<Author>> GetAll()
        {
            var result = _authorDal.GetAll();
            return new SuccessDataResult<List<Author>>(result);

        }

        public IDataResult<Author> GetById(int id)
        {
            var result = _authorDal.Get(x => x.Id == id);
            if (result is not null)
            {
                return new SuccessDataResult<Author>(result);
            }
            return new ErrorDataResult<Author>("Author not found");
        }
    }
}
