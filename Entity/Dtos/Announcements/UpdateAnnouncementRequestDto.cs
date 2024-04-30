using Core.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dtos.Announcements
{
    public class UpdateAnnouncementRequestDto:IDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
}
