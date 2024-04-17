using Business.Abstract;
using Core.ResponseStructure;
using DataAccess.Abstract;
using Models.Concrete;
using Models.Dtos.NewsFeed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class NewsFeedManager : INewsFeedService
    {
        INewsFeedDal _newsFeedDal;

        public NewsFeedManager(INewsFeedDal newsFeedDal)
        {
            _newsFeedDal = newsFeedDal;
        }

        public async Task<IResult> CreateNewsFeedAsync(CreateNewsFeedRequestDto createNewsFeedRequestDto)
        {
            var existingNewsFeed = await _newsFeedDal.GetAsync(x => x.Title == createNewsFeedRequestDto.Title);
            if (existingNewsFeed != null)
            {
                return new ErrorResult("A news feed with the same title already exists.");
            }

            if (createNewsFeedRequestDto.NewsFeedType == Models.Enums.NewsFeedEnums.Event)
            {
                var evennt = new Event()
                {
                    Description = createNewsFeedRequestDto.Description,
                    NewsFeedType = Models.Enums.NewsFeedEnums.Event,
                    Link = createNewsFeedRequestDto.Link,
                    EventTime = createNewsFeedRequestDto.EventTime,
                    Title = createNewsFeedRequestDto.Title
                };

                await _newsFeedDal.AddAsync(evennt);
                return new SuccessResult("News feed created successfully.");

            }
            if (createNewsFeedRequestDto.NewsFeedType == Models.Enums.NewsFeedEnums.Announcement)
            {
                var announcement = new Announcement()
                {
                    Description = createNewsFeedRequestDto.Description,
                    NewsFeedType = Models.Enums.NewsFeedEnums.Event,
                    Link = createNewsFeedRequestDto.Link,
                    Title = createNewsFeedRequestDto.Title
                };
                await _newsFeedDal.AddAsync(announcement);
                return new SuccessResult ( "News feed created successfully.");
            }
            return new ErrorResult("News Feed Not Created");
        }


        public async Task<IResult> DeleteNewsFeedById(int newsFeedId)
        {
            var existNewsFeed = await _newsFeedDal.GetAsync(x=>x.Id == newsFeedId);
            if (existNewsFeed is not null)
            {
                await _newsFeedDal.DeleteAsync(existNewsFeed);
                return new SuccessResult(message: "News Feed Deleted");
            }
            return new ErrorResult(message:"News Feed Not Found");
        }

        public async Task<IResult> UpdateNewsFeed(UpdateNewsFeedRequestDto updateNewsFeedRequestDto)
        {
            var existNewsFeed = await _newsFeedDal.GetAsync(x => x.Id == updateNewsFeedRequestDto.Id);

            if (existNewsFeed is null)
            {
                return new ErrorResult("News Feed Not Found");
            }

            existNewsFeed.Title = updateNewsFeedRequestDto.Title;
            existNewsFeed.Description = updateNewsFeedRequestDto.Description;
            existNewsFeed.NewsFeedType = updateNewsFeedRequestDto.NewsFeedType;
            await _newsFeedDal.UpdateAsync(existNewsFeed);
            return new SuccessResult(message: "Succeed Update");
        }
    }
}
