using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        IProjectService _projectService;

        public ProjectsController(IProjectService projectService)
        {
            _projectService = projectService;
        }


        [HttpGet("getAllProjects")]

        public IActionResult GetAll()
        {
            var result = _projectService.GetAllProjects();
            return Ok(result);
        }

        [HttpPost("createProject")]

        public IActionResult CreateProject(Project project)
        {
            var result = _projectService.CreateProject(project);
            if (result.Success)
            {
               return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getProjectById/{id}")]

        public IActionResult GetProjectById(int id)
        {
            var result = _projectService.GetProjectById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("updateProject")]

        public IActionResult UpdateProject(Project project)
        {
            var result = _projectService.UpdateProject(project);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("deleteProjectById/{id}")]

        public IActionResult DeleteProject(int id)
        {
            var result = _projectService.DeleteProjectById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return NotFound(result);
        }
    }
}
