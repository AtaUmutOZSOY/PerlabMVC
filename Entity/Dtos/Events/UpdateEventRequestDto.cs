﻿using Core.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dtos.Events
{
    public class UpdateEventRequestDto:IDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime EventTime { get; set; }
        public string EventLink { get; set; }
    }
}
