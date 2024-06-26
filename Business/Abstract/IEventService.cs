﻿using Core.Utilities.Results;
using Models.Dtos.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IEventService
    {
        IResult UpdateEvent(UpdateEventRequestDto updateEventRequestDto);
    }
}
