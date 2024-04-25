using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Concrete;
using Models.Dtos.Collaborations;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollaborationsController : ControllerBase
    {
        ICollaborationService _collaborationService;

        public CollaborationsController(ICollaborationService collaborationService)
        {
            _collaborationService = collaborationService;
        }

        [HttpGet("getAllCollaborations")]


        public IActionResult GetAll()
        {
            var result = _collaborationService.GetAllCollaborations();
            return Ok(result);
        }

        [HttpPost("createCollaboration")]
        public IActionResult CreateColaboration(CreateCollaborationRequestDto createCollaborationRequestDto)
        {
            var newCollaboration = new Collaboration()
            {
                ImageBase64String = createCollaborationRequestDto.ImageBase64String,
                CollaborationName = createCollaborationRequestDto.CollaborationName,
                CollaborationWebSiteLink = createCollaborationRequestDto.CollaborationWebSiteLink
            };
            var result = _collaborationService.CreateCollaboration(newCollaboration);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("updateCollaborationName")]

        public IActionResult UpdateCollaborationName(UpdateCollaborationNameRequestDto updateCollaborationNameRequestDto)
        {
            var result = _collaborationService.UpdateCollaborationName(updateCollaborationNameRequestDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("deleteCollaborationById/{id}")]

        public IActionResult DeleteCollaborationById(int id)
        {
            var result = _collaborationService.DeleteCollaborationById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return NotFound(result);
        }

        [HttpPut("updateCollaborationWebSiteLink")]

        public IActionResult UpdateCollaborationWebSiteLink(UpdateCollaborationWebSiteLinkRequestDto updateCollaborationWebSiteLinkRequestDto)
        {
            var result = _collaborationService.UpdateCollaborationWebSiteLink(updateCollaborationWebSiteLinkRequestDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
