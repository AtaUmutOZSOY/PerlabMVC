using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Concrete;
using Models.Dtos.Events;
using Models.Dtos.NewsFeed;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        INewsFeedService _newsFeedService;
        IEventService _eventService;

        public EventsController(INewsFeedService newsFeedService,IEventService eventService)
        {
            _newsFeedService = newsFeedService;
            _eventService = eventService;
        }


        [HttpGet("getAllEvents")]

        public IActionResult GetAllEvents() 
        {
            var result = _newsFeedService.GetAllEvents();
            return Ok(result); 
        }

        [HttpPost("createNewEvent")]

        public IActionResult CreateNewEvent(CreateNewsFeedRequestDto createNewsFeedRequestDto)
        {

            var result = _newsFeedService.CreateNewsFeed(createNewsFeedRequestDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);


        }

        [HttpDelete("deleteEventById/{id}")]

        public IActionResult DeleteById(int id)
        {
            var result = _newsFeedService.DeleteNewsFeedById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("updateEvent")]

        public IActionResult UpdateEvent(UpdateEventRequestDto updateEventRequestDto)
        {
            var result = _eventService.UpdateEvent(updateEventRequestDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return NotFound(result);
        }
    }
}
