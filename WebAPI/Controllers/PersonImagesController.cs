using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Dtos.PersonImage;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonImagesController : ControllerBase
    {
        IPersonImageService _personImageService;

        public PersonImagesController(IPersonImageService personImageService)
        {
            _personImageService = personImageService;
        }

        [HttpGet("getPersonImageByPersonId/{personId}")]

        public IActionResult GetPersonImageByPersonId(int personId)
        {
            var result = _personImageService.GetPersonImageByPersonId(personId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("updatePersonImage")]

        public IActionResult UpdatePersonImage(UpdatePersonImageRequestDto updatePersonImageRequestDto)
        {
            var result = _personImageService.UpdatePersonImage(updatePersonImageRequestDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("removePersonImageFromPerson")]

        public IActionResult RemovePersonImageFromPerson([FromQuery] int personId, [FromQuery] int personImageId )
        {
            var result = _personImageService.RemovePersonImageFromPerson(personId, personImageId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("createPersonImage")]

        public IActionResult CreatePersonImage([FromBody] CreatePersonImageRequestDto createPersonImageRequestDto)
        {
            var result = _personImageService.CreatePersonImage(createPersonImageRequestDto);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
