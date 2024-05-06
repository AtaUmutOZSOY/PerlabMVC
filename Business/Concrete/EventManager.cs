using Business.Abstract;
using Business.Constants.Messages;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Models.Dtos.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EventManager : IEventService
    {
        IEventDal _eventDal;

        public EventManager(IEventDal eventDal)
        {
            _eventDal = eventDal;
        }

        public IResult UpdateEvent(UpdateEventRequestDto updateEventRequestDto)
        {
            var existEvent = _eventDal.Get(x=>x.Id == updateEventRequestDto.Id);
            if (existEvent != null)
            {
                existEvent.Title = updateEventRequestDto.Title;
                existEvent.Description = updateEventRequestDto.Description;
                existEvent.EventTime = updateEventRequestDto.EventTime;
                existEvent.Link = updateEventRequestDto.EventLink;
                _eventDal.Update(existEvent);
                return new SuccessResult(Messages.SucceedUpdate);
            }
            return new ErrorResult("Event not found!");
        }
    }
}
