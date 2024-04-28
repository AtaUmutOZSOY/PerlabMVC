﻿using Core.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class Research : Entity
    {
        public Research(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public Research()
        {
            
        }
        public string Title { get; set; }
        public string? Description { get; set; }

    }
}
