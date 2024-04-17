using Core.EntityCore;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dtos.NewsFeed
{
    public class UpdateNewsFeedRequestDto:IDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public NewsFeedEnums NewsFeedType { get; set; }
    }
}
