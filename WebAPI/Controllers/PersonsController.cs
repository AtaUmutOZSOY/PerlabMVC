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

        [HttpPost("createNewPerson")]

        public IActionResult CreatePerson(CreateNewPersonRequestDto createPersonRequestDto)
        {
            var result = _personService.CreatePerson(createPersonRequestDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getAllPeople")]

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

        [HttpPut("updatePersonImage")]

        public IActionResult UpdatePersonImage([FromQuery] int id, [FromQuery] string personImageBase64String)
        {
            var result = _personService.ChangePersonImage(id, personImageBase64String);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("uploadPersonImage")]

        public async Task<IActionResult> UploadImage(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("No file uploaded.");

            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", file.FileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return Ok(new { path = $"/images/{file.FileName}" });
        }
    }
}
