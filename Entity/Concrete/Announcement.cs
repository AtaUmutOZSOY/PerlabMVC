using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class Announcement : NewsFeed
    {
        public Announcement(string title, string description) : base(title, description)
        {
        }
    }
}
