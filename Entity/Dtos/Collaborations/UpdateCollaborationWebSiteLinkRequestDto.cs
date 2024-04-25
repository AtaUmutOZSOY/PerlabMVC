using Core.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dtos.Collaborations
{
    public class UpdateCollaborationWebSiteLinkRequestDto:IDto
    {
        public int Id { get; set; }
        public string NewCollaborationWebSiteLink { get; set; }
    }
}
