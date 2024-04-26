using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResearchsController : ControllerBase
    {
        IResearchService _researchService;

        public ResearchsController(IResearchService researchService)
        {
            _researchService = researchService;
        }

        [HttpPost("createResearch")]
        public IActionResult CreateResearch(Research research)
        {
            var result = _researchService.Add(research);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("deleteResearchById/{id}")]


        public IActionResult DeleteResearchById(int id)
        {
            var result = _researchService.DeleteById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getResearchById/{id}")]

        public IActionResult GetResearchById(int id)
        {
            var result = _researchService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getAllResearchs")]

        public IActionResult GetAllResearchs()
        {
            var result = _researchService.GetAll();
            return Ok(result);
        }
    }
}
