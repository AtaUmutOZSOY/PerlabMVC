using Business.Abstract;
using Business.Constants.Messages;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Models.Concrete;
using Models.Dtos.PersonImage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonImageManager : IPersonImageService
    {
        IPersonImageDal _personImageDal;
        IPersonService _personService;

        public PersonImageManager(IPersonImageDal personImageDal,IPersonService personService)
        {
            _personImageDal = personImageDal;
            _personService = personService;
        }

        public IResult CreatePersonImage(CreatePersonImageRequestDto createPersonImageRequestDto)
        {

            var newPersonImage = new PersonImage()
            {
                Base64String = createPersonImageRequestDto.Base64String,
                PersonId = createPersonImageRequestDto.PersonId
            };

            var isImageExist = CheckExistPersonImage(createPersonImageRequestDto.PersonId);
            
            if (isImageExist.Success)
            {
                _personImageDal.Add(newPersonImage);
                return new SuccessResult(Messages.SucceedAdd);
            }
            return new ErrorResult(isImageExist.Message);
        }

        private IResult CheckExistPersonImage(int personId)
        {
            var result = _personImageDal.Get(x=>x.PersonId == personId);
            if (result is not null)
            {
                return new ErrorResult("This person already has an image");
            }
            return new SuccessResult();
        }
        public IDataResult<List<PersonImage>> GetAllPersonImages()
        {
            var result = _personImageDal.GetAll();
            return new SuccessDataResult<List<PersonImage>>(result);
        }

        public IDataResult<PersonImage> GetById(int id)
        {
            var image = _personImageDal.Get(x=>x.Id == id);
            if (image is not null)
            {
                return new SuccessDataResult<PersonImage>(image);
            }
            return new ErrorDataResult<PersonImage>("İmage not found");
        }

        public IDataResult<PersonImage> GetPersonImageByPersonId(int personId)
        {
            var personImage = _personImageDal.Get(x=> x.PersonId == personId);
            if (personImage is not null)
            {
                return new SuccessDataResult<PersonImage>(personImage);
            }
            return new ErrorDataResult<PersonImage>("Person image not found");
        }

        public IResult RemovePersonImageFromPerson(int personId, int personImageId)
        {
            var person = _personService.GetById(personId);
            if (person is not null)
            {
                person.Data.PersonImageId = 0;
                var result = _personService.UpdatePerson(person.Data);
                if (result.Success)
                {
                    return new SuccessResult("Image removed successfully from the given person");
                }
                return new ErrorResult(result.Message);
            }
            return new ErrorResult("Person not found");
        }

        public IResult UpdatePersonImage(UpdatePersonImageRequestDto updatePersonImageRequestDto)
        {
            var personImage = _personImageDal.Get(x => x.PersonId == updatePersonImageRequestDto.PersonId);
            if (personImage is not null)
            {
                personImage.Base64String = updatePersonImageRequestDto.Base64String;
                _personImageDal.Update(personImage);
                return new SuccessResult(Messages.SucceedUpdate);
            }
            return new ErrorResult("Person image not founds");
        }
    }
}
