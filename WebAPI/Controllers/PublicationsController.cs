using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Concrete;
using Models.Dtos.Authors;
using Models.Dtos.Publications;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublicationsController : ControllerBase
    {
        IPublicationService _publicationService;


        public PublicationsController(IPublicationService publicationService)
        {
            _publicationService = publicationService;
        }

        [HttpGet("getAllPublications")]

        public IActionResult GetAll()
        {
            var result = _publicationService.GetAllPublications();
            return Ok(result);
        }

        [HttpGet("getPublicationById/{id}")]

        public IActionResult GetById(int id)
        {
            var result = _publicationService.GetPublicationById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return NotFound(result);
        }

        [HttpPost("createNewPublication")]

        public IActionResult CreatePublication(CreateNewPublicationRequestDto publication) { 
            
            var result = _publicationService.CreateNewPublication(publication);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("deletePublicationById/{id}")]

        public IActionResult DeletePublicationById(int id)
        {
            var result = _publicationService.DeletePublicationById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("assignAuthorToExistPublication")]

        public IActionResult AssignAuthorToPublication(AssignAuthorToExistPublicationRequestDto assignAuthorToExistPublicationRequestDto)
        {
            var result  = _publicationService.AssignAuthorToExistPublication(assignAuthorToExistPublicationRequestDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
