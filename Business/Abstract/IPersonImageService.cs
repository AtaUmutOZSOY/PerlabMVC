using Core.Utilities.Results;
using Models.Concrete;
using Models.Dtos.PersonImage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPersonImageService
    {
        IResult CreatePersonImage(CreatePersonImageRequestDto createPersonImageRequestDto);
        IResult RemovePersonImageFromPerson(int personId, int personImageId);

        IResult UpdatePersonImage(UpdatePersonImageRequestDto updatePersonImageRequestDto);

        IDataResult<PersonImage> GetPersonImageByPersonId(int personId);
        IDataResult<PersonImage> GetById(int id);

        IDataResult<List<PersonImage>> GetAllPersonImages();
    }
}
