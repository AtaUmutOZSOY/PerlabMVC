using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Dtos.NewsFeed;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsFeedsController : ControllerBase
    {
        INewsFeedService _newsFeedService;

        public NewsFeedsController(INewsFeedService newsFeedService)
        {
            _newsFeedService = newsFeedService;
        }

        [HttpGet("getAllNewsFeeds")]

        public IActionResult GetAllNewsFeeds()
        {
            var result = _newsFeedService.GetAll();
            return Ok(result);
        }

        [HttpPost("createNewsFeed")]

        public IActionResult CreateNewsFeed(CreateNewsFeedRequestDto createNewsFeedRequestDto)
        {

            var result = _newsFeedService.CreateNewsFeed(createNewsFeedRequestDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("updateNewsFeed")]

        public IActionResult UpdateNewsFeed(UpdateNewsFeedRequestDto updateNewsFeedRequestDto)
        {
            var result = _newsFeedService.UpdateNewsFeed(updateNewsFeedRequestDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("deleteNewsFeedById/{newsFeedId}")]

        public IActionResult DeleteNewsFeed(int newsFeedId)
        {
            var result = _newsFeedService.DeleteNewsFeedById(newsFeedId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
