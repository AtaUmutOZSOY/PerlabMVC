using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Dtos.Announcements;
using Models.Dtos.NewsFeed;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncementsController : ControllerBase
    {
        INewsFeedService _newsFeedService;
        IAnnouncementService _announcementService;
        public AnnouncementsController(INewsFeedService newsFeedService,IAnnouncementService announcementService)
        {
            _newsFeedService = newsFeedService;
            _announcementService = announcementService;
        }

        [HttpGet("getAllAnnouncements")]

        public IActionResult GetAllAnnouncements()
        {
            var result = _newsFeedService.GetAllAnnouncements();

            return Ok(result);

        }

        [HttpPut("updateAnnouncement")]

        public IActionResult UpdateAnnouncement(UpdateAnnouncementRequestDto updateAnnouncementRequestDto)
        {
            var result = _announcementService.UpdateAnnouncement(updateAnnouncementRequestDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
