using Core.DataAccess.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Models.Concrete;
using Models.Dtos.Authors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfPublicationDal : EfEntityRepositoryBase<Publication, PerlabDbContext>, IPublicationDal
    {

        public IResult AssignAuthorToExistPublication(AssignAuthorToExistPublicationRequestDto assignAuthorToExistPublicationRequestDto)
        {
            using (var context = new PerlabDbContext())
            {
                var publication = context.Publications.FirstOrDefault(x=>x.Id == assignAuthorToExistPublicationRequestDto.PublicationId);
                if (publication is null)
                {
                    return new ErrorResult("Publication not found");
                }
                var author = context.Authors.FirstOrDefault(x => x.Id == assignAuthorToExistPublicationRequestDto.AuthorId);
                if (author is null)
                {
                    return new ErrorResult("Author not found");
                }
                publication.Authors.Add(author);
                context.Update(publication);
                context.SaveChanges();
                return new SuccessResult();
            }
        }
    }
}
