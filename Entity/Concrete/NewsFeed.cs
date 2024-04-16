using Core.EntityCore;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class NewsFeed : Entity
    {
        public NewsFeed(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public NewsFeedEnums NewsFeedType { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string? Link { get; set; }
    }
}
