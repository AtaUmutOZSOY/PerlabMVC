using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Concrete;

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
        public IActionResult CreateColaboration(Collaboration collaboration)
        {
            var result = _collaborationService.CreateCollaboration(collaboration);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
