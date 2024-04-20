using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        INewsFeedService _newsFeedService;

        public EventsController(INewsFeedService newsFeedService)
        {
            _newsFeedService = newsFeedService;
        }


        [HttpGet("getAllEvents")]

        public IActionResult GetAllEvents() 
        {
            var result = _newsFeedService.GetAllEvents();
            return Ok(result); 
        }
    }
}
