using Business.Abstract;
using DataAccess.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Dtos.Person;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        IPersonService _personService;

        public PersonsController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpPost("createPerson")]

        public IActionResult CreatePerson(CreatePersonRequestDto createPersonRequestDto)
        {
            var result = _personService.CreatePerson(createPersonRequestDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getAllPersons")]

        public IActionResult GetAllPeople()
        {
            var result = _personService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("deletePersonById/{id}")]

        public IActionResult DeletePerson(int id)
        {
            var result = _personService.DeletePersonById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("updatePersonVisualRank")]

        public IActionResult UpdatePersonVisualRank([FromQuery] int id, [FromQuery] int visualRank)
        {
            var result = _personService.UpdatePersonVisualRank(id, visualRank);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
