using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Core.Entity.Concretes;
using Core.Utilities.Results;
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
        //[SecuredOperation("admin")]
        public IResult CreateNewsFeed(CreateNewsFeedRequestDto createNewsFeedRequestDto)
        {
            var existingNewsFeed = _newsFeedDal.Get(x => x.Title == createNewsFeedRequestDto.Title);
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

                _newsFeedDal.Add(evennt);
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
                _newsFeedDal.Add(announcement);
                return new SuccessResult ( "News feed created successfully.");
            }
            return new ErrorResult("News Feed Not Created");
        }


        //[SecuredOperation("admin")]

        public IResult DeleteNewsFeedById(int newsFeedId)
        {
            var existNewsFeed = _newsFeedDal.Get(x => x.Id == newsFeedId);
            if (existNewsFeed is not null)
            {
                _newsFeedDal.Delete(existNewsFeed);
                return new SuccessResult(message: "News Feed Deleted");
            }
            return new ErrorResult(message:"News Feed Not Found");
        }

        public IDataResult<List<NewsFeed>> GetAll()
        {
            var result = _newsFeedDal.GetAll();
            return new SuccessDataResult<List<NewsFeed>>(result);   
        }


        //[SecuredOperation("admin")]

        public IResult UpdateNewsFeed(UpdateNewsFeedRequestDto updateNewsFeedRequestDto)
        {
            var existNewsFeed = _newsFeedDal.Get(x => x.Id == updateNewsFeedRequestDto.Id);

            if (existNewsFeed is null)
            {
                return new ErrorResult("News Feed Not Found");
            }

            existNewsFeed.Title = updateNewsFeedRequestDto.Title;
            existNewsFeed.Description = updateNewsFeedRequestDto.Description;
            existNewsFeed.NewsFeedType = updateNewsFeedRequestDto.NewsFeedType;
            _newsFeedDal.Update(existNewsFeed);
            return new SuccessResult(message: "Succeed Update");
        }
    }
}
