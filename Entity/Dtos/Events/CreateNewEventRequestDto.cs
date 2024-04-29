using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dtos.Events
{
    public class CreateNewEventRequestDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string EventLink { get; set; }
        public DateTime EventTime { get; set; }

    }
}
