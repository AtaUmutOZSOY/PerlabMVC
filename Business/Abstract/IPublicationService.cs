using Core.Utilities.Results;
using Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPublicationService
    {
        IResult CreateNewPublication(Publication publication);
        IResult DeletePublicationById(int id);
        IDataResult<Publication> GetPublicationById(int id);
        IDataResult<List<Publication>> GetAllPublications();

        IResult UpdatePublication();
    }
}
