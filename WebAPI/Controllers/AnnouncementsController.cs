using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Dtos.NewsFeed;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncementsController : ControllerBase
    {
        INewsFeedService _newsFeedService;

        public AnnouncementsController(INewsFeedService newsFeedService)
        {
            _newsFeedService = newsFeedService;
        }

        [HttpGet("getAllAnnouncements")]

        public IActionResult GetAllAnnouncements()
        {
            var result = _newsFeedService.GetAllAnnouncements();

            return Ok(result);

        }
    }
}
