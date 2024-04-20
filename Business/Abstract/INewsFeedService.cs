using Core.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Concrete;
using Models.Dtos.NewsFeed;
using Core.Utilities.Results;
namespace Business.Abstract
{
    public interface INewsFeedService
    {
        IResult CreateNewsFeed(CreateNewsFeedRequestDto createNewsFeedRequestDto);
        IResult UpdateNewsFeed(UpdateNewsFeedRequestDto updateNewsFeedRequestDto);
        IResult DeleteNewsFeedById(int newsFeedId);
        IDataResult<List<NewsFeed>> GetAll();

        IDataResult<List<Announcement>> GetAllAnnouncements();
        IDataResult<List<Event>> GetAllEvents();
    }
}
