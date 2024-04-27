using Business.Abstract;
using Business.Constants.Messages;
using Core.Utilities.Business;
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
    public class PublicationManager : IPublicationService
    {
        IPublicationDal _publicationDal;
        IAuthorService _authorService;
        public PublicationManager(IPublicationDal publicationDal)
        {
            _publicationDal = publicationDal;
        }

        public IResult CreateNewPublication(Publication publication)
        {
            var result = BusinessRules.Run(CheckExistPublicationByDoi(publication.Doi),CheckAuthors(publication.Authors));
            if (result.Success)
            {
                _publicationDal.Add(publication);
                return new SuccessResult(Messages.SucceedAdd);
            }
            return new ErrorResult(result.Message);
        }

        private IResult CheckAuthors(List<Author> authors)
        {
           int notFoundCount=0;
           foreach (Author author in authors)
           {
                var existAuthor = _authorService.GetById(author.Id);
                if (existAuthor.Data is null)
                {
                    notFoundCount++;
                }
           }
           if (notFoundCount > 0) 
           {
                return new ErrorResult();
           }
           return new SuccessResult();

        }

        private IResult CheckExistPublicationByDoi(string doi)
        {
            var result = _publicationDal.Get(x => x.Doi == doi);
            if(result is null)
            {
                return new SuccessResult();
            }
            return new ErrorResult("Publication already exist");
        }

        public IResult DeletePublicationById(int id)
        {
            var publication = _publicationDal.Get(x=>x.Id == id);
            if (publication is not null)
            {
                _publicationDal.Delete(publication);
                return new SuccessResult(Messages.SucceedDelete);
            }
            return new ErrorResult("Publication not found");
        }

        public IDataResult<List<Publication>> GetAllPublications()
        {
            var result = _publicationDal.GetAll();
            return new SuccessDataResult<List<Publication>>(result);
        }

        public IDataResult<Publication> GetPublicationById(int id)
        {
            var result = _publicationDal.Get(x=>x.Id ==id);

            if (result is not null)
            {
                return new SuccessDataResult<Publication>(result);
            }
            return new ErrorDataResult<Publication>();
        }

        public IResult UpdatePublication()
        {
            throw new NotImplementedException();
        }
    }
}
