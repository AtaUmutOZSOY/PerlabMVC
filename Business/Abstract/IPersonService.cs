using Core.Utilities.Results;
using Models.Concrete;
using Models.Dtos.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPersonService
    {
        IResult CreatePerson(CreatePersonRequestDto createLaboratoryPersonRequestDto);
        IResult DeletePersonById(int id);
        IResult UpdatePersonVisualRank(int id,int visualRank);
        IDataResult<Person> GetById(int id);
        IDataResult<List<Person>> GetAll();
        IResult UpdatePerson(Person person);

        IResult ChangePersonImage(int id, string personImageBase64String);
    }
}
