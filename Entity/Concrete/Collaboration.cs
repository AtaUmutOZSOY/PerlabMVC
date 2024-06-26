﻿using Core.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class Collaboration : Entity
    {
        public Collaboration(string collaborationName, string collaborationWebSiteLink)
        {
            CollaborationName = collaborationName;
            CollaborationWebSiteLink = collaborationWebSiteLink;
        }
        public Collaboration()
        {
            
        }
        public string CollaborationName { get; set; }
        public string CollaborationWebSiteLink { get; set; }
        public string ImageBase64String { get; set; }
    }
}
