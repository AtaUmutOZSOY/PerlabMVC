using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class Event : NewsFeed
    {
        public Event(string title, string description) : base(title, description)
        {

        }

        public Event()
        {
            
        }
        public DateTime EventTime { get; set; }
    }
}
