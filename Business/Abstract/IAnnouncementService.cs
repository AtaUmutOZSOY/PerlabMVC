using Core.Utilities.Results;
using Models.Dtos.Announcements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAnnouncementService
    {
        IResult UpdateAnnouncement(UpdateAnnouncementRequestDto updateAnnouncementRequestDto);
    }
}
