using Business.Abstract;
using Business.Constants.Messages;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Models.Concrete;
using Models.Dtos.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager : IPersonService
    {
        IPersonDal _personDal;

        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }

        public IResult ChangePersonImage(int id , string personImageBase64String)
        {
            var existPerson = _personDal.Get(x=>x.Id == id);
            existPerson.PersonImageBase64String = personImageBase64String;
            _personDal.Update(existPerson);
            return new SuccessResult(Messages.SucceedUpdate);
        }

        public IResult CreatePerson(CreatePersonRequestDto createLaboratoryPersonRequestDto)
        {
            var fullName = createLaboratoryPersonRequestDto.FirstName + " " + createLaboratoryPersonRequestDto?.MiddleName + " " + createLaboratoryPersonRequestDto.LastName;
            var result = CheckExistPerson(fullName);
            if(result.Success)
            {
                var newPerson = new Person()
                {
                    LastName = createLaboratoryPersonRequestDto.LastName,
                    MiddleName = createLaboratoryPersonRequestDto.MiddleName,
                    FirstName = createLaboratoryPersonRequestDto.FirstName,
                    LinkedInUrl = createLaboratoryPersonRequestDto.LinkedInUrl,
                    OrcidUrl = createLaboratoryPersonRequestDto.OrcidUrl,
                    ResearchGateUrl = createLaboratoryPersonRequestDto.ResearchGateUrl,
                    GraduateTypeEnum = createLaboratoryPersonRequestDto.GraduateTypeEnum,
                    GraduateSchoolName = createLaboratoryPersonRequestDto.GraduateSchoolName,
                    VisualRank = createLaboratoryPersonRequestDto.VisualRank,
                    PersonImageBase64String = createLaboratoryPersonRequestDto.Base64String
                };
                _personDal.Add(newPerson);
                return new SuccessResult(Messages.SucceedAdd);
            }
            return new ErrorResult("This person already exist");
        }

        public IResult DeletePersonById(int id)
        {
            var existPerson = _personDal.Get(x=>x.Id == id);
            if (existPerson is null)
            {
                return new ErrorResult("Person not found");
            }
            _personDal.Delete(existPerson);
            return new SuccessResult(Messages.SucceedDelete);
        }

        public IDataResult<List<Person>> GetAll()
        {
            var result = _personDal.GetAll();
            return new SuccessDataResult<List<Person>>(result);
        }

        public IDataResult<Person> GetById(int id)
        {
            var result = _personDal.Get(x=>x.Id == id);
            if (result is null)
            {
                return new ErrorDataResult<Person>("Person not Found");
            }
            return new SuccessDataResult<Person>(result);
        }

        public IResult UpdatePerson(Person person)
        {
            var existPerson = _personDal.Get(x=>x.Id ==person.Id);
            if (existPerson is null)
            {
                return new ErrorResult("Person not found");
            }
            existPerson.OrcidUrl = person.OrcidUrl;
            existPerson.ResearchGateUrl = person.ResearchGateUrl;
            existPerson.PersonImageBase64String = person.PersonImageBase64String;
            existPerson.FirstName = person.FirstName;
            existPerson.LastName = person.LastName;
            existPerson.MiddleName = person.MiddleName;
            existPerson.VisualRank = person.VisualRank;

            _personDal.Update(existPerson);

            return new SuccessResult(Messages.SucceedUpdate);
        }

        public IResult UpdatePersonVisualRank(int id, int visualRank)
        {
            var existPerson = _personDal.Get(x=>x.Id ==id);
            if (existPerson is null)
            {
                return new ErrorResult("Person not found");
            }
            existPerson.VisualRank = visualRank;
            _personDal.Update(existPerson);
            return new SuccessResult("Rank of" + existPerson.FullName+ "changed");
        }

        private IResult CheckExistPerson(string fullName)
        {
            var existPerson = _personDal.Get(x => x.FullName == fullName);
            if (existPerson is not null)
            {
                return new ErrorResult("Person already exist.");
            }
            return new SuccessResult();

        }
    }
}
