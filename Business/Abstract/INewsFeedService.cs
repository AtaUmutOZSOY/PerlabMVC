using Core.ResponseStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ResponseStructure;
using Models.Concrete;
using Models.Dtos.NewsFeed;
namespace Business.Abstract
{
    public interface INewsFeedService
    {
        Task<IResult> CreateNewsFeedAsync(CreateNewsFeedRequestDto createNewsFeedRequestDto);
        Task<IResult> UpdateNewsFeed(UpdateNewsFeedRequestDto updateNewsFeedRequestDto);
        Task<IResult> DeleteNewsFeedById(int newsFeedId);
    }
}
