using Core.EntityCore;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dtos.NewsFeed
{
    public class CreateNewsFeedRequestDto:IDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string? Link { get; set; }
        public NewsFeedEnums NewsFeedType { get; set; }
        public DateTime EventTime { get; set; }
    }
}
