using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Concrete;
using Models.Dtos.Authors;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        IAuthorService _authorService;

        public AuthorsController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet("getAllAuthors")]
        public IActionResult GetAll()
        {
            var result = _authorService.GetAll();
            return Ok(result);
        }

        [HttpGet("getAuthorById/{id}")]
        public IActionResult Get(int id)
        {
            var result = _authorService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return NotFound(result);
        }

        [HttpPost("createNewAuthor")]

        public IActionResult CreateNewAuthor(CreateAuthorRequestDto createAuthorRequestDto)
        {
            var result = _authorService.CreateNewAuthor(createAuthorRequestDto);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
