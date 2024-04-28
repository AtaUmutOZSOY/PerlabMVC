using Core.Utilities.Results;
using Models.Concrete;
using Models.Dtos.Authors;
using Models.Dtos.Publications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPublicationService
    {
        IResult CreateNewPublication(CreateNewPublicationRequestDto createNewPublicationRequestDto);

        IResult AssignAuthorToExistPublication(AssignAuthorToExistPublicationRequestDto assignAuthorToExistPublicationRequestDto);
        IResult DeletePublicationById(int id);
        IDataResult<Publication> GetPublicationById(int id);
        IDataResult<List<Publication>> GetAllPublications();

        IResult UpdatePublication();
    }
}
