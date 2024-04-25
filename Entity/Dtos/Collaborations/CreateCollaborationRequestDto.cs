using Core.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dtos.Collaborations
{
    public class CreateCollaborationRequestDto:IDto
    {
        public string CollaborationName { get; set; }
        public string CollaborationWebSiteLink { get; set; }
        public string ImageBase64String { get; set; }
    }
}
