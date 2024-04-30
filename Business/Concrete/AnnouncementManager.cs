using Business.Abstract;
using Business.Constants.Messages;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Models.Dtos.Announcements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AnnouncementManager : IAnnouncementService
    {
        IAnnouncementDal _announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public IResult UpdateAnnouncement(UpdateAnnouncementRequestDto updateAnnouncementRequestDto)
        {
            var existAnnouncement = _announcementDal.Get(x=>x.Id ==  updateAnnouncementRequestDto.Id);
            if (existAnnouncement == null)
            {
                return new ErrorResult("Announcement not found");
            }
            existAnnouncement.Title = updateAnnouncementRequestDto.Title;
            existAnnouncement.Description = updateAnnouncementRequestDto.Description;
            _announcementDal.Update(existAnnouncement);
            return new SuccessResult(Messages.SucceedUpdate);
        }
    }
}
