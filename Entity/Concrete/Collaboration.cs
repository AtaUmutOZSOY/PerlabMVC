using Core.EntityCore;
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

        public string CollaborationName { get; set; }
        public string CollaborationWebSiteLink { get; set; }
    }
}
