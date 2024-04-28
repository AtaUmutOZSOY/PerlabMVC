using Core.DataAccess.Abstract;
using Core.Utilities.Results;
using Models.Concrete;
using Models.Dtos.Authors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IPublicationDal:IEntityRepository<Publication>
    {
        IResult AssignAuthorToExistPublication(AssignAuthorToExistPublicationRequestDto assignAuthorToExistPublicationRequestDto);
    }
}
